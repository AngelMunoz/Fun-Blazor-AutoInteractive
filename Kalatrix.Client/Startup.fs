﻿#nowarn "0020"

open System
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting

let builder = WebAssemblyHostBuilder.CreateDefault(Environment.GetCommandLineArgs())

builder.Services.AddFunBlazorWasm()

builder.Build().RunAsync()
