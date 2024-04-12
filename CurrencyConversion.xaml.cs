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
	public sealed partial class CurrencyConversion : Page
	{
		private float amount;
		private String from;
		private String to;
		private float convertedAmount;
		 
		public CurrencyConversion()
		{
			this.InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				amount = float.Parse(amountTextBox.Text);
			}
			catch(Exception E)
			{
				outputTextBlock.Text = "Error";
			}
			from = fromComboBox.SelectedValue.ToString();
			to = toComboBox.SelectedValue.ToString();

			if ((from == "USD - US Dollar") && (to == "EUR - Euro"))
			{
				convertedAmount = (float)(amount * 0.85189982);
				outputTextBlock.Text = $"{amount} US Dollars = \n{convertedAmount} Euros \n1 USD = 0.85189982 Euros\n1 Euro = 1.1739732 USD";
			}
			else if ((from == "USD - US Dollar") && (to == "GBP - Pound Sterling"))
			{
				convertedAmount = (float)(amount * 0.72872436);
				outputTextBlock.Text = $"{amount} US Dollars = \n{convertedAmount} Pound Sterling \n1 USD = 0.72872436 British Pounds\n1 British Pound = 1.1739732 USD";

			}
			else if ((from == "USD - US Dollar") && (to == "INR - Indian Rupee"))
			{
				convertedAmount = (float)(amount * 74.257327);
				outputTextBlock.Text = $"{amount} US Dollars = \n{convertedAmount} Indian Rupee \n1 USD = 0.72872436 Indian Rupees\n1 Indian Rupee = 0.011492628 USD";

			}
			else if ((from == "EUR - Euro") && (to == "USD - US Dollar"))
			{
				convertedAmount = (float)(amount * 1.1739732);
				outputTextBlock.Text = $"{amount} Euros = \n{convertedAmount} US Dollars \n1 Euro = 0.1.1739732 US Dollars\n1 US Dollar = 0.85189982 Euros";

			}
			else if ((from == "EUR - Euro") && (to == "GBP - Pound Sterling"))
			{
				convertedAmount = (float)(amount * 0.8556672);
				outputTextBlock.Text = $"{amount} Euros = \n{convertedAmount} British Pounds \n1 Euro = 0.8556672 Pound Sterling\n1 British Pound = 1.1686692 Euros";

			}
			else if ((from == "EUR - Euro") && (to == "INR - Indian Rupee"))
			{
				convertedAmount = (float)(amount * 87.00755);
				outputTextBlock.Text = $"{amount} Euros = \n{convertedAmount} Indian Rupees \n1 Euro = 87.00755 Indian Rupees\n1 Indian Rupee = 0.013492774 Euros";

			}
			else if ((from == "GBP - Pound Sterling") && (to == "USD - US Dollar"))
			{
				convertedAmount = (float)(amount * 1.371907);
				outputTextBlock.Text = $"{amount} British Pounds = \n{convertedAmount} US Dollars \n1 British Pound = 1.371907 US Dollars\n1 US Dollar = 0.72872436 British Pounds";
			}
			else if ((from == "GBP - Pound Sterling") && (to == "EUR - Euro"))
			{
				convertedAmount = (float)(amount * 1.1686692);
				outputTextBlock.Text = $"{amount} British Pounds = \n{convertedAmount} Euros \n1 British Pound = 1.1686692 Euros\n1 Euro = 0.8556672 British Pounds";
			}
			else if ((from == "GBP - Pound Sterling") && (to == "INR - Indian Rupee"))
			{
				convertedAmount = (float)(amount * 101.68635);
				outputTextBlock.Text = $"{amount} British Pounds = \n{convertedAmount} Indian Rupees \n1 British Pound = 101.68635 Indian Rupees\n1 Indian Rupee = 0.0098339397 British Pounds";
			}
			else if ((from == "INR - Indian Rupee") && (to == "USD - US Dollar"))
			{
				convertedAmount = (float)(amount * 0.011492628);
				outputTextBlock.Text = $"{amount} Indian Rupees = \n{convertedAmount} US Dollars \n1 Indian Rupee = 0.011492628 US Dollars\n1 US Dollar = 74.257327 Indian Rupees";
			}
			else if ((from == "INR - Indian Rupee") && (to == "EUR - Euro"))
			{
				convertedAmount = (float)(amount * 0.013492774);
				outputTextBlock.Text = $"{amount} Indian Rupees = \n{convertedAmount} Euros \n1 Indian Rupee = 0.013492774 US Dollars\n1 Euro = 87.00755 Indian Rupees";
			}
			else if ((from == "INR - Indian Rupee") && (to == "GBP - Pound Sterling"))
			{
				convertedAmount = (float)(amount * 0.0098339397);
				outputTextBlock.Text = $"{amount} Indian Rupees = \n{convertedAmount} British Pounds \n1 Indian Rupee = 0.0098339397 British Pounds\n1 British Pound = 101.68635 Indian Rupees";
			}
			else
			{
				outputTextBlock.Text = "Error";
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
	}
}
