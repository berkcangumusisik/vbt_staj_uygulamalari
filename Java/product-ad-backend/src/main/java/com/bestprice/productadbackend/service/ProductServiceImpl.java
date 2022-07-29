package com.bestprice.productadbackend.service;

import com.bestprice.productadbackend.entity.Product;
import com.bestprice.productadbackend.repository.ProductRepository;
import org.springframework.stereotype.Service;

@Service
public class ProductServiceImpl implements ProductService {

    private final ProductRepository productRepository;

    public ProductServiceImpl(ProductRepository productRepository) {
        this.productRepository = productRepository;
    }

    @Override
    public Product save(Product product) {

        return productRepository.save(product);
    }

    @Override
    public Product findByName(String name) {
        return productRepository.findByName(name);
    }
}
