namespace OrderLibrary

module PriceDecorator =  
    let discountPrice price = price * 0.8
    let rebatePrice price = price - 100.0
    