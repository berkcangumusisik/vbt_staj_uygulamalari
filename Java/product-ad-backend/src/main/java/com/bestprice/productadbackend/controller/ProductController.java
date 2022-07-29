package com.bestprice.productadbackend.controller;

import com.bestprice.productadbackend.entity.Product;
import com.bestprice.productadbackend.service.ProductService;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/product")
public class ProductController {

    private final ProductService productService;

    public ProductController(ProductService productService) {
        this.productService = productService;
    }

    @PostMapping
    public ResponseEntity save(@RequestBody Product product) {
        Product product1 = productService.save(product);
        return ResponseEntity.ok(product1);
    }

    @GetMapping("/name/{name}")
    public ResponseEntity findByName(@PathVariable("name") String name) {
        Product product1 = productService.findByName(name);
        return ResponseEntity.ok(product1);
    }
}
