create database Zadanie2;
create table Categories (id bigint not null primary key, name nvarchar(256) not null );
create table Products (id bigint not null primary key, name nvarchar(256) not null );
create table ProductsCategories
(
product_id bigint,
category_Id bigint,
foreign key (product_id) references Products(id),
foreign key (category_id) references Categories (id),
constraint PK_ProductsCategories primary key (product_id,category_id)
);

select p.name, c.name from products p
left outer join productscategories pc on p.id = pc.product_id 
left join categories c on c.id = pc.category_idcategories