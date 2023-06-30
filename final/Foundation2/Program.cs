List<Products> _products1 = new List<Products>();
Customers John = new Customers("John Smith" ,new Address("3 Moshor Dr","Nashua","NH","USA"));
Order _order1 = new Order(_products1,John);
_products1.Add(new Products("milk",214, 5.64, 4));
_products1.Add(new Products("carrots",231, 3.64, 10));
_products1.Add(new Products("bowl",532, 5.00, 2 ));
_order1.DisplayOrder();


List<Products> _products2 = new List<Products>();
Customers Jane = new Customers("Jane DOe" ,new Address("24 Asher Dr","Saquoa","Alberta","CAN"));
Order _order2 = new Order(_products2,Jane);
_products2.Add(new Products("Television",23942, 300.99, 1));
_products2.Add(new Products("Speakers",891281, 18.99, 4));
_products2.Add(new Products("Batteries",1414124, 15.39, 3 ));
_order2.DisplayOrder();
