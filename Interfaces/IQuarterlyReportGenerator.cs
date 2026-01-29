using System;

namespace Files_ASync;

public interface IQuarterlyReportGenerator
{
    void GenerateQuarterlyReport(BankCustomer bankCustomer, int accountNumber, DateOnly reportDate);
}
