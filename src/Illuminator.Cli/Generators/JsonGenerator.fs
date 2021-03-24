module JsonGenerator

open Scriban
open Shared

let private template = @"
[
  {{~ for code in codes ~}}
  {
    ""name"": ""{{code.name}}"",
    ""description"": ""TBD"",
    ""args"": [ ]
  },
  {{~ end ~}}
]"

let generate () =
    let scriban = Template.Parse template
    let result = scriban.Render {| codes = FilteredCodes |> Seq.map (fun (name, _) -> {| name = name |}) |}
    result.Trim()