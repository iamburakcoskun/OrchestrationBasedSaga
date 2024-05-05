﻿namespace Shared
{
    public class RabbitMQSettings
    {
        public const string OrderSaga = "order-saga-queue";

        public const string StockOrderCreatedEventQueue = "stock-order-created-queue";

        public const string StockReservedEventQueueName = "stock-reserved-queue";

        public const string StockNotReservedEventQueueName = "stock-not-reserved-queue";

        public const string StockPaymentFailedEventQueueName = "stock-payment-failed-queue";

        public const string OrderPaymentCompletedEventQueueName = "order-payment-completed-queue";

        public const string OrderPaymentFailedEventQueueName = "order-payment-failed-queue";

    }
}
