SELECT product.name, category.name
FROM product LEFT JOIN products_categories USING (product.id = products_categories.product_id)
    LEFT JOIN categories USING (products_categories.category_id = category.id);