from pyspark.sql import SparkSession
# датафреймы products и categories имеют связь многие ко многим, так как у продукта есть 
# много категорий, а у категории есть много продуктов. Следовательно, необходима 
# промежуточный датафрейм product_categories, который связвает продукты и категории.

def get_product_categories(products_dataframe, categories_dataframe, products_categories_dataframe):
    return products.join(products_categories_dataframe, products_dataframe.id == products_categories_dataframe.id_product, "left").\
    join(categories_dataframe, categories.id == products_categories_dataframe.id_category,"left").\
        select(products_dataframe.name.alias("product name"), categories_dataframe.name.alias("category name"))

    

spark = SparkSession.builder.appName('spark_session').getOrCreate()
# датафрейм products
products = spark.createDataFrame(
    [(1,"product_a"),
     (2,"product_b"),
     (3,"product_c"),
     (4,"product_d"),
     (5,"product_e"),
     (6,"product_f"),],
    ["id","name"]
)
# датафрейм categories
categories = spark.createDataFrame(
    [(1, "Cat_a"),
     (2, "Cat_b"),
     (3, "Cat_c"),
     (4, "Cat_d"),],
    ["id", "name"]
) 
# датафрейм product_categories
prd_cat = spark.createDataFrame(
    [(1,1),
     (1,2),
     (1,3),
     (1,4),
     (2,3),
     (2,4),
     (5,1),
     (5,3),
     (6,2),],
    ["id_product", "id_category"]
)

get_product_categories(products, categories,prd_cat).show()