namespace MauiSample.Core

module Domain =
    type ProductId = ProductId of int

    module ProductId =
        let create id = 
            if id < 0 then 
                Error "Product id cannot be negative." 
            else 
                Ok (ProductId id)

        let value (ProductId id) = id

    type ProductName = ProductName of string

    module ProductName =
        let value (ProductName productName) = productName

    type Category = 
        | Electronics
        | Crafting
        | Kitchen

    type Product = 
        {
            Id: ProductId
            Name: ProductName
            Category: Category
        }
        with
            override this.ToString () =
                sprintf "%s (%s)" (this.Name |> ProductName.value) (this.Category.ToString ())

    module Product =
        let create id name category =
            let idResult = ProductId.create id

            match idResult with
            | Ok i -> Ok { Id = i ; Name = (ProductName name) ; Category = category }
            | Error e -> Error e
