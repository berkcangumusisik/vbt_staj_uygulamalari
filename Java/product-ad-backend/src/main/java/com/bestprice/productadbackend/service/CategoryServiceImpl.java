package com.bestprice.productadbackend.service;

import com.bestprice.productadbackend.entity.Category;
import com.bestprice.productadbackend.repository.CategoryRepository;
import org.springframework.stereotype.Service;

@Service
public class CategoryServiceImpl implements CategoryService {

    private final CategoryRepository categoryRepository;

    public CategoryServiceImpl(CategoryRepository categoryRepository) {
        this.categoryRepository = categoryRepository;
    }


    @Override
    public Category save(Category category) {
        return categoryRepository.save(category);
    }

}
