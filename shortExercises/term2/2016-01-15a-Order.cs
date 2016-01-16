// Orders

// http://sce.uhcl.edu/helm/rationalunifiedprocess/process/modguide/images/rdb-oo6.gif

// Chen Chao
// 15-01-2016

public class Order
{
    protected int number;
    protected Customer customer;
    protected LineItem[] lineItem;
}

public class LineItem
{
    protected int number;
    protected int quantity;
    protected Product myProduct;
}

public class Product
{
    protected int number;
    protected string description;
    protected double unitPrice;
    protected Supplier mySupplier;
}

public class SoftwareProduct : Product
{
    protected double version;
}

public class HardwareProduct : Product
{
    protected string assembly;
}

public class Customer
{
    protected int id;
    protected string name;
    protected Address address;
}

public class Supplier
{
    protected int id;
    protected string name;
    protected Address address;
}

public class Address
{
    protected string street;
    protected string city;
    protected string state;
    protected string postalCode;
    protected string country;
}


public class OrderManagementSystem
{
    public static void Main()
    {
        // TO DO
    }
}
