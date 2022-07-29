package com.bestprice.productadbackend.controller;

import com.bestprice.productadbackend.entity.Category;
import com.bestprice.productadbackend.service.CategoryService;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/category")
public class CategoryController {

    private final CategoryService categoryService;

    public CategoryController(CategoryService categoryService) {
        this.categoryService = categoryService;
    }

    @PostMapping
    public ResponseEntity save(@RequestBody Category category) {
        Category category1=categoryService.save(category);
        return ResponseEntity.ok(category1);
    }
}
