using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SymbolTableApp
{
    public partial class Form1 : Form
    {
        // Declare the symbol table (dictionary)
        private Dictionary<string, string> symbolTable = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        // Optional: Form load event (if needed)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        // Add button click handler
        private void addButton_Click(object sender, EventArgs e)
        {
            string symbol = symbolTextBox.Text;
            string info = infoTextBox.Text;

            if (!string.IsNullOrEmpty(symbol) && !string.IsNullOrEmpty(info))
            {
                if (!symbolTable.ContainsKey(symbol))
                {
                    symbolTable[symbol] = info;
                    resultLabel.Text = $"Symbol '{symbol}' added.";
                }
                else
                {
                    resultLabel.Text = $"Symbol '{symbol}' already exists!";
                }
            }
            else
            {
                resultLabel.Text = "Please enter both symbol and information.";
            }
        }

        // Search button click handler
        private void searchButton_Click(object sender, EventArgs e)
        {
            string symbol = symbolTextBox.Text;

            if (symbolTable.ContainsKey(symbol))
            {
                string info = symbolTable[symbol];
                resultLabel.Text = $"Symbol: {symbol}, Info: {info}";
            }
            else
            {
                resultLabel.Text = $"Symbol '{symbol}' not found.";
            }
        }

        // Delete button click handler
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string symbol = symbolTextBox.Text;

            if (symbolTable.ContainsKey(symbol))
            {
                symbolTable.Remove(symbol);
                resultLabel.Text = $"Symbol '{symbol}' deleted.";
            }
            else
            {
                resultLabel.Text = $"Symbol '{symbol}' not found.";
            }
        }
    }
}
