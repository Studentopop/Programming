namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит состояние заказов в процессе его выполнения.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
