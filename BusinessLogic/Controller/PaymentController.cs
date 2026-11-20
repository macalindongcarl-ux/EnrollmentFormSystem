using System;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class PaymentController
    {
        private readonly PaymentRepository _paymentRepo;

        public PaymentController()
        {
            _paymentRepo = new PaymentRepository(); 
        }

        public List<AssessedAccountModel> GetAssessedAccounts()
        {
            return _paymentRepo.GetAssessedAccounts(); 
        }

        public List<PaymentModel> GetAll(bool includeInactive, string searchTerm = null)
        {
            return _paymentRepo.GetAll(includeInactive, searchTerm); 
        }

        public bool ProcessPayment(PaymentModel payment, decimal currentRemainingBalance, out string receiptNumber, out string errorMessage)
        {
            receiptNumber = string.Empty; 
            errorMessage = string.Empty;  

            if (payment == null || payment.AssessmentID <= 0) 
            {
                errorMessage = "Please select an assessed student account."; 
                return false;
            }

            if (payment.AmountPaid <= 0) 
            {
                errorMessage = "Payment amount must be greater than 0.00.";
                return false; 
            }

            if (payment.AmountPaid > currentRemainingBalance)
            {
                errorMessage = $"Payment amount (₱{payment.AmountPaid:N2}) cannot exceed the remaining balance (₱{currentRemainingBalance:N2}).";
                return false; 
            }

            if (string.IsNullOrWhiteSpace(payment.PaymentMethod))
            {
                errorMessage = "Please select a payment method.";
                return false; 
            }

            if (!payment.PaymentMethod.Equals("Cash", StringComparison.OrdinalIgnoreCase) &&
                string.IsNullOrWhiteSpace(payment.ReferenceNumber))
            {
                errorMessage = $"Reference number is required for {payment.PaymentMethod} payments.";
                return false;
            }

            if (payment.ProcessedByUserID <= 0)
            {
                errorMessage = "Invalid cashier user session.";
                return false;
            }

            try
            {
                receiptNumber = _paymentRepo.Add(payment);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public bool VoidPayment(int paymentId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (paymentId <= 0)
            {
                errorMessage = "Please select a valid payment record to void.";
                return false;
            }

            try
            {
                _paymentRepo.Deactivate(paymentId);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}