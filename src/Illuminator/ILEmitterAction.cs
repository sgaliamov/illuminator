using System;

namespace Illuminator
{
    /// <summary>
    /// Wrapper around <see cref="Action{ILEmitter}"/> to enable Pipe operator.
    /// </summary>
    public struct ILEmitterAction : IEquatable<ILEmitterAction>
    {
        private readonly Action<ILEmitter> _action;

        public ILEmitterAction(Action<ILEmitter> action) => _action = action;

        /// <summary>
        /// To be able convert <see cref="ILEmitterAction"/> to <see cref="Action{ILEmitter}"/> parameter in methods.
        /// </summary>
        public static implicit operator Action<ILEmitter>(ILEmitterAction action) => action._action;

        public static implicit operator ILEmitterAction(Action<ILEmitter> action) => new ILEmitterAction(action);

        /// <summary>
        /// To be able pipe two actions.
        /// </summary>
        public static ILEmitterAction operator |(ILEmitterAction a, ILEmitterAction b) => a._action + b._action;

        public static ILEmitter operator |(ILEmitterAction a, ILEmitter il)
        {
            a._action(il);

            return il;
        }

        public bool Equals(ILEmitterAction other) => _action.Equals(other);

        public override bool Equals(object obj) => obj is ILEmitterAction action && Equals(action);

        public override int GetHashCode() => _action.GetHashCode();

        public static bool operator ==(ILEmitterAction left, ILEmitterAction right) => left.Equals(right);

        public static bool operator !=(ILEmitterAction left, ILEmitterAction right) => !(left == right);
    }
}
