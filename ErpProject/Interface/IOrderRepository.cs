﻿using ErpProject.Models;

namespace ErpProject.Interface
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        Order getOrderById(int id); 
        Order addOrder(Order order);    
        Order updateOrder(Order order); 
        void deleteOrder(int id);  
    }
}
