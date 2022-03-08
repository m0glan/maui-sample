namespace MauiSample.Core.Facade

open MauiSample.Core.Domain
open MauiSample.Core.Utils

type IProductService =
    abstract member GetProducts : unit -> Product seq

type ProductService () =
    let products = [
        Product.create 1 "Dell XPS 15" Category.Electronics |> Result.get
        Product.create 2 "Spoon" Category.Kitchen |> Result.get
        Product.create 3 "iPhone 13" Category.Electronics |> Result.get
        Product.create 4 "Hammer" Category.Crafting |> Result.get
    ]

    interface IProductService with
        member this.GetProducts(): seq<Product> = products