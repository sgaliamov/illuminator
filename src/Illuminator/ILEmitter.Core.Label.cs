using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Illuminator.Exceptions;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        private readonly IDictionary<Label, LabelInfo> _labelInfos = new Dictionary<Label, LabelInfo>();

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.MarkLabel(Label)" />.
        /// </summary>
        public ILEmitter MarkLabel(in Label loc)
        {
            ValidateLabel(loc);
            _il.MarkLabel(loc);

            return this;
        }

        private void ValidateLabel(in Label label) => GetLabelInfo(label).ValidateLabel(_il.ILOffset);

        private void ValidateJump(Label label) => GetLabelInfo(label).ValidateJump(_il.ILOffset);

        private LabelInfo GetLabelInfo(Label loc)
        {
            if (_labelInfos.TryGetValue(loc, out var info)) {
                return info;
            }

            info = new LabelInfo();
            _labelInfos.Add(loc, info);

            return info;
        }

        private sealed class LabelInfo
        {
            private int? _labelPosition;
            private int? _jumpPosition;

            public void ValidateLabel(int offset)
            {
                _labelPosition = offset;

                if (!_jumpPosition.HasValue) {
                    return;
                }

                Validate(_labelPosition.Value, _jumpPosition.Value);
            }

            public void ValidateJump(int offset)
            {
                _jumpPosition = offset;

                if (!_labelPosition.HasValue) {
                    return;
                }

                Validate(_labelPosition.Value, _jumpPosition.Value);
            }

            private static void Validate(int labelPosition, int jumpPosition)
            {
                if (Math.Abs(labelPosition - jumpPosition) >= 127) {
                    throw new IlluminatorJumpException(
                        $"Cannot make short jump from position {jumpPosition} to {labelPosition}.");
                }
            }
        }
    }
}
