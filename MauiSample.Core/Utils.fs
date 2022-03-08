namespace MauiSample.Core

module Utils =
    module Result =
        let get res =
            match res with
            | Ok x -> x
            | Error e -> failwith e

