module JsonGenerator

open Scriban
open OpCodes

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
    let codes =
        FilteredCodes 
        |> Seq.map (fun (name, _, _) -> name) 
        |> Seq.distinct 
        |> Seq.map (fun name -> {| name = name |})

    let result = scriban.Render {| codes = codes |}
    result.Trim()