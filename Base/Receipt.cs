﻿using RetailCorrector.Enums;
using System;

namespace RetailCorrector
{

    /// <summary>
    /// Информация о чеке
    /// </summary>
    public struct Receipt
    {
        /// <summary>
        /// Дата и время отбития оригинального чека
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// Тип чека
        /// </summary>
        public Operation Operation { get; set; }
        /// <summary>
        /// Позиции
        /// </summary>
        public Position[] Items { get; set; }
        /// <summary>
        /// Фискальный признак
        /// </summary>
        public string FiscalSign { get; set; }
        /// <summary>
        /// Тип коррекции
        /// </summary>
        public CorrType CorrectionType { get; set; }
        /// <summary>
        /// Оплата
        /// </summary>
        public Payment Payment { get; set; }
        /// <summary>
        /// Округлённая итоговая сумма
        /// </summary>
        public uint? RoundedSum { get; set; }
    }
}