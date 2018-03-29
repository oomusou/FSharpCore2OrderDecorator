namespace OrderLibrary

open PriceDecorator

module OrderService =
    let getPrice price = 
        match (price > 1000.0) with
        | true -> (discountPrice >> rebatePrice) price
        | false -> discountPrice price