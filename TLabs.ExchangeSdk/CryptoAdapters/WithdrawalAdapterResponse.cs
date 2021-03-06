namespace TLabs.ExchangeSdk.CryptoAdapters
{
    /// <summary>
    /// Модель ответа на вывод денег
    /// </summary>
    public class WithdrawalAdapterResponse
    {
        /// <summary>
        /// Сообщение
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// Величина комиссии, полученная после отправки транзакции
        /// </summary>
        public decimal ActualFee { get; set; }

        /// <summary>
        /// Статус ответа
        /// </summary>
        public WithdrawalAdapterResponseStatus Status { get; set; }

        /// <summary>
        /// Идентификатор транзакции в блокчейне
        /// </summary>
        public string TxId { get; set; }
    }

    /// <summary>
    /// Статус ответа на вывод денег
    /// </summary>
    public enum WithdrawalAdapterResponseStatus
    {
        /// <summary>
        /// Успешно
        /// </summary>
        Success,

        /// <summary>
        /// Не предвиденная ошибка
        /// </summary>
        Error,
    }
}
