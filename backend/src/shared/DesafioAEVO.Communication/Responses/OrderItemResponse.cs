﻿namespace DesafioAEVO.Communication.Responses
{
    public class OrderItemResponse
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
