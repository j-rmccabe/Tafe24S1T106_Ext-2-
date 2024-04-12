using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}
		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}

		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			double principalLoanamount;
			double monthlyInterestRate;
			double monthstoRepay;
			double monthlyPayment;

			monthstoRepay = (double.Parse(yearTextBox.Text) * 12) + double.Parse(monthTextBox.Text);


			monthlyInterestRate = (double.Parse(yearlyInterestTextBox.Text)) / 1200;

			principalLoanamount = double.Parse(principalBorrowTextBox.Text);

			//monthlyPayment = principalLoanamount * (Math.Pow((monthlyInterestRate * (1 + monthlyInterestRate)), monthstoRepay) / (Math.Pow(1 + monthlyInterestRate, monthstoRepay - 1)));
			monthlyPayment = CalculateMortgageRepayment(principalLoanamount, monthlyInterestRate, monthstoRepay);

			monthlyInterestTextBox.Text = monthlyInterestRate.ToString("P");
			monthlyRepaymentTextBox.Text = monthlyPayment.ToString("C");

		}
		private double CalculateMortgageRepayment(double P, double i, double n)
		{
			//double M = P * i * (Math.Pow(1 + i, n) / (Math.Pow(1 + i, n - 1)));
			double A = Math.Pow((1 + i), n);
			//double B = Math.Pow(1 + i, n - 1);
			double C = (i * A) / (A - 1);
			double M = P * C;

			return M;
		}
	}
}


