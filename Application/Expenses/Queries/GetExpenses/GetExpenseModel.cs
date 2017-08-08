﻿using System;

namespace Application.Expenses.Queries.GetExpenses
{
    public class GetExpenseModel
    {
        public int Id { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int ExpenseAccountId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public int BranchId { get; set; }
        public Decimal Value { get; set; }
        public int CurrencyId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}