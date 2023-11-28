namespace Kalatrix.Components

open System.Reflection
open Fun.Blazor
open Kalatrix.Components.Layout

type Routes() =
    inherit FunComponent()

    override _.Render() =
        Router'() {
            AppAssembly(typeof<Routes>.Assembly)
            AdditionalAssemblies([| typeof<Kalatrix.Client.Counter>.Assembly |])

            Found(fun routeData ->
                RouteView'() {
                    RouteData routeData
                    DefaultLayout typeof<MainLayout>
                })
        }
