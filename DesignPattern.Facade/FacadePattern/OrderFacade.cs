using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order= new Order();
        OrderDetail orderDetail= new OrderDetail();
        ProductStock productStock= new ProductStock();
        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();
        public void CompleteOrderDetail(int customerID,int productID,int orderID,int productCount,decimal productPrice)
        {


            orderDetail.CustomerID = customerID;
            orderDetail.ProductID = productID;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice; 
            orderDetail.OrderID = orderID;
            orderDetail.ProductTotalPrice= productCount * productPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productID,productCount);
        }
        public void CompleteOrder(int customerID)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);
        }
    }
}
