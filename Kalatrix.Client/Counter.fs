namespace Kalatrix.Client

open Microsoft.AspNetCore.Components

open FSharp.Data.Adaptive

open Fun.Blazor


[<Route "/counter">]
[<FunInteractiveAuto>]
type Counter() =
    inherit FunBlazorComponent()
    let counter = cval (0)

    override _.Render() =
        adaptiview () {
            let! count, setCount = counter.WithSetter()

            div { $"Current count: %i{count}" }

            button {
                onclick (fun _ -> setCount (count + 1))
                "Click me"
            }
        }
