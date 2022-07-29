package com.bestprice.productadbackend.service;

import com.bestprice.productadbackend.entity.Product;

public interface ProductService {
    Product save(Product product);
    Product findByName(String name);
}
