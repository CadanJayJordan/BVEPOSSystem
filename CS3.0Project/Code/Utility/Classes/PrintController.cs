using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Configuration;
using System.Windows.Forms;

namespace CS3._0Project.Code.Utility.Classes {
    
    internal class PrintController { // Handles all the print events

        private string username = "";
        private int tableNumber = 0;

        private List<string> itemNames = new List<string>();
        private List<int> itemQuantitys = new List<int>();
        private List<List<string>> itemListItems = new List<List<string>>();
        private List<string> itemListNotes = new List<string>();
        private List<bool> itemPrintRed = new List<bool>();

        private List<decimal> itemPrice = new List<decimal>();

        //Printer from config
        private string billPrinter = ConfigurationSettings.AppSettings.Get("billPrinter");
        private string kitchenPrinter = ConfigurationSettings.AppSettings.Get("kitchenPrinter");

        private bool printToKitchen;

        // Declare Fonts
        private Font SegoeUI8Reg = new Font("Segoe UI", 8, FontStyle.Regular);
        private Font SegoeUI10Reg = new Font("Segoe UI", 10, FontStyle.Regular);

        private Font SegoeUI8Semibold = new Font("Segoe UI Semibold", 8, FontStyle.Bold);
        private Font SegoeUI10Semibold = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        private Font SegoeUI12Semibold = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
 

        public void printTicket(bool printToKitchen, string username, int tableNumber, List<string> itemNames, List<int> itemQuantitys, List<List<string>> itemListItems, List<string> itemListNotes, List<bool> itemPrintRed) { // Print a ticket 
            // Get external info
            this.printToKitchen = printToKitchen;
            this.username = username;
            this.tableNumber = tableNumber;
            this.itemNames = itemNames;
            this.itemQuantitys = itemQuantitys;
            this.itemListItems = itemListItems;
            this.itemListNotes = itemListNotes;
            this.itemPrintRed = itemPrintRed;

            groupCommonItems();

            // Create printer settings based off name
            PrinterSettings printSettings = new PrinterSettings();
            if (printToKitchen) {
                printSettings.PrinterName = kitchenPrinter;
            } else {
                printSettings.PrinterName = billPrinter;
            }

            // Create the print document
            PrintDocument ticket = new PrintDocument();
            ticket.DocumentName = "Till Ticket " + DateTime.Now.ToString();
            ticket.PrintPage += new PrintPageEventHandler(printTicketPage);
            ticket.PrintController = new StandardPrintController();
            ticket.PrinterSettings = printSettings;

            //ticket.Print();

            // Debugging print dialog
            PrintPreviewDialog printDlg = new PrintPreviewDialog();
            printDlg.Document = ticket;
            printDlg.Width = 300;
            printDlg.Height = 900;
            printDlg.ShowDialog();

            ticket.Dispose();
        }

        public void printBill(string username, int tableNumber, List<string> itemNames, List<int> itemQuantitys, List<List<string>> itemListItems, List<string> itemListNotes, List<decimal> itemPrice) { // Print a ticket 
            // Get external info
            this.username = username;
            this.tableNumber = tableNumber;
            this.itemNames = itemNames;
            this.itemQuantitys = itemQuantitys;
            this.itemListItems = itemListItems;
            this.itemListNotes = itemListNotes;
            this.itemPrice = itemPrice;

            // Create printer settings based off name
            PrinterSettings printSettings = new PrinterSettings();
            printSettings.PrinterName = billPrinter;
            // Create the print document
            PrintDocument bill = new PrintDocument();
            bill.DocumentName = "Bill Ticket";
            bill.PrintPage += new PrintPageEventHandler(printBillPage);
            bill.PrintController = new StandardPrintController();
            bill.PrinterSettings = printSettings;

            //ticket.Print();

            // Debugging print dialog
            PrintPreviewDialog printDlg = new PrintPreviewDialog();
            printDlg.Document = bill;
            printDlg.Width = 300;
            printDlg.Height = 900;
            printDlg.ShowDialog();

            bill.Dispose();
        }

        private void groupCommonItems() { // Attempt to group all items that are simialr togeather.
            // Create new lists to print
            List<string> itemNamesG = new List<string>();
            List<int> itemQuantitysG = new List<int>();
            List<List<string>> itemListItemsG = new List<List<string>>();
            List<string> itemListNotesG = new List<string>();
            List<bool> itemPrintRedG = new List<bool>();

            bool foundInNew = false;
            int newIndex = -1;

            for (int i = 0; i < this.itemNames.Count; i++) {  // For ungrouped items
                foundInNew = false;
                newIndex = -1;
                for (int j = 0; j < itemNamesG.Count; j++) { // For all grouped items
                    if (itemNames[i] != itemNamesG[j]) { // If the names match
                        continue;
                    }

                    bool isListItemMatch = false;
                    if (itemListItemsG[j].Count != 0) {
                        foreach (string itemListName in itemListItems[i]) {
                            if (itemListItemsG[j].Contains(itemListName)) {
                                isListItemMatch = true;
                                continue;
                            }
                            isListItemMatch = false;
                            break;
                        }
                    } else {
                        if (itemListItems[i].Count == 0) {
                            isListItemMatch = true;
                        }
                    }

                    if (!isListItemMatch) { // Checking the condition from above, if not match restart
                        continue;
                    }

                    if (itemListNotes[i] != itemListNotesG[j]) { // If notes are equal
                        continue;
                    }

                    if (itemPrintRed[i] != itemPrintRedG[j]) { // If they both print red 
                        continue;
                    }

                    // They are a match
                    foundInNew = true;
                    newIndex = j;
                }

                if (foundInNew) { // If it already exists in the new list
                    itemQuantitysG[newIndex] += itemQuantitys[i]; // Add the quantities togeather
                } else { // If it is not in the new list
                    itemNamesG.Add(itemNames[i]); // Ad the item in the new list
                    itemQuantitysG.Add(itemQuantitys[i]);
                    itemListItemsG.Add(itemListItems[i]);
                    itemListNotesG.Add(itemListNotes[i]);
                    itemPrintRedG.Add(itemPrintRed[i]);
                }
            }

            itemNames = itemNamesG;
            itemQuantitys = itemQuantitysG;
            itemListItems = itemListItemsG;
            itemListNotes = itemListNotesG;
            itemPrintRed = itemPrintRedG;
        }

        private void printTicketPage(object sender, PrintPageEventArgs e) {
            float maxWidth = 200.0F; // Printer specific max width
            float height = 0.0F;

            float x = 10;
            float y = 5;

            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            // Declare string formats for alignment
            StringFormat drawLeft = new StringFormat();
            drawLeft.Alignment = StringAlignment.Near;

            StringFormat drawCenter = new StringFormat();
            drawCenter.Alignment = StringAlignment.Center;

            StringFormat drawRight = new StringFormat();
            drawRight.Alignment = StringAlignment.Far;

            // Draw Strings to screen
            string text = "";

            text = username; // Username
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawLeft);

            text = DateTime.Now.ToShortTimeString(); // Time
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawRight);
            y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;

            if (printToKitchen) { // Bar/Kitchen
                text = "Kitchen"; 
            } else {
                text = "Bar";
            }
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawLeft);

            text = DateTime.Now.ToLongDateString(); // Date
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawRight);
            y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;

            text = new String('=', 19); // Divider
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(5, y, maxWidth, height), drawCenter);
            y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;

            if (tableNumber > -1) { // If there is an open table
                text = "Table: " + tableNumber; // Table number
                e.Graphics.DrawString(text, SegoeUI12Semibold, blackBrush, new RectangleF(x, y, maxWidth, height), drawCenter);
                y += e.Graphics.MeasureString(text, SegoeUI12Semibold).Height;

                text = new String('=', 19); // Divider
                e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(5, y, maxWidth, height), drawCenter);
                y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;
            }

            for (int i = 0; i < itemNames.Count; i++) { // For the items
                SolidBrush activeBrush = blackBrush; // Default brush is black

                if (itemPrintRed[i]) { // If item requires red brush, change it
                    activeBrush = redBrush;
                } 

                text = itemQuantitys[i].ToString(); // item quantnity
                e.Graphics.DrawString(text, SegoeUI10Semibold, activeBrush, new RectangleF(x, y, maxWidth, height), drawLeft);

                float x2 = x + e.Graphics.MeasureString("999", SegoeUI10Reg).Width; // new x coordinate for indented items

                text = itemNames[i]; // item name
                e.Graphics.DrawString(text, SegoeUI10Reg, activeBrush, new RectangleF(x2, y, maxWidth, height), drawLeft);
                y += e.Graphics.MeasureString(text, SegoeUI10Semibold).Height;

                foreach (string selectedItem in itemListItems[i]) { // For any list items
                    text = itemQuantitys[i].ToString(); // Quantity
                    e.Graphics.DrawString(text, SegoeUI10Semibold, activeBrush, new RectangleF(x2, y, maxWidth, height), drawLeft);

                    text = selectedItem; // List item text
                    e.Graphics.DrawString(text, SegoeUI10Reg, activeBrush, new RectangleF(x2 + e.Graphics.MeasureString("999", SegoeUI10Reg).Width, y, maxWidth, height), drawLeft);
                    y += e.Graphics.MeasureString(text, SegoeUI10Semibold).Height;
                }

                string[] itemNotes = itemListNotes[i].Split('\n');
                foreach(string itemNote in itemNotes) { // for any note
                    text = itemNote; // add the note
                    e.Graphics.DrawString(text, SegoeUI10Reg, activeBrush, new RectangleF(x2, y, maxWidth, height), drawLeft);
                    y += e.Graphics.MeasureString(text, SegoeUI10Semibold).Height;
                }
            }

            text = new String('-', 33); // Final divider to signify end of ticket
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(5, y, maxWidth, height), drawCenter);
            y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;
        }

        private void printBillPage(object sender, PrintPageEventArgs e) {
            float maxWidth = 200.0F; // Printer specific max width
            float height = 0.0F;

            float x = 10;
            float y = 5;

            SolidBrush blackBrush = new SolidBrush(Color.Black);

            // Declare string formats for alignment
            StringFormat drawLeft = new StringFormat();
            drawLeft.Alignment = StringAlignment.Near;

            StringFormat drawCenter = new StringFormat();
            drawCenter.Alignment = StringAlignment.Center;

            StringFormat drawRight = new StringFormat();
            drawRight.Alignment = StringAlignment.Far;

            // Draw Strings to screen
            string text = "";

            text = username; // Username
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawLeft);

            text = DateTime.Now.ToShortTimeString(); // Time
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawRight);
            y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;

            text = DateTime.Now.ToLongDateString(); // Date
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawRight);
            y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;

            text = new String('=', 19); // Divider
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(5, y, maxWidth, height), drawCenter);
            y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;

            if (tableNumber > -1) { // If there is an open table
                text = "Table: " + tableNumber; // Table number
                e.Graphics.DrawString(text, SegoeUI10Semibold, blackBrush, new RectangleF(x, y, maxWidth, height), drawCenter);
                y += e.Graphics.MeasureString(text, SegoeUI10Semibold).Height;

                text = new String('=', 19); // Divider
                e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(5, y, maxWidth, height), drawCenter);
                y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;
            }

            int priceIndexOffset = 0; // Tracks 

            for (int i = 0; i < itemNames.Count; i++) { // For the items
                text = itemQuantitys[i].ToString(); // item quantnity
                e.Graphics.DrawString(text, SegoeUI8Semibold, blackBrush, new RectangleF(x, y, maxWidth, height), drawLeft);

                float x2 = x + e.Graphics.MeasureString("999", SegoeUI8Semibold).Width; // new x coordinate for indented items

                text = itemNames[i]; // item name
                e.Graphics.DrawString(text, SegoeUI8Reg, blackBrush, new RectangleF(x2, y, maxWidth, height), drawLeft);

                text = "£" + itemPrice[i + priceIndexOffset].ToString("0.00"); // List item text
                e.Graphics.DrawString(text, SegoeUI8Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawRight);
                y += e.Graphics.MeasureString(text, SegoeUI8Semibold).Height;

                foreach (string selectedItem in itemListItems[i]) { // For any list items
                    priceIndexOffset++;

                    text = itemQuantitys[i].ToString(); // Quantity
                    e.Graphics.DrawString(text, SegoeUI8Semibold, blackBrush, new RectangleF(x2, y, maxWidth, height), drawLeft);

                    text = selectedItem; // List item text
                    e.Graphics.DrawString(text, SegoeUI8Reg, blackBrush, new RectangleF(x2 + e.Graphics.MeasureString("999", SegoeUI10Reg).Width, y, maxWidth, height), drawLeft);

                    text = "£" + itemPrice[i + priceIndexOffset].ToString("0.00"); // List item text
                    e.Graphics.DrawString(text, SegoeUI8Reg, blackBrush, new RectangleF(x, y, maxWidth, height), drawRight);
                    y += e.Graphics.MeasureString(text, SegoeUI8Semibold).Height;
                }

                string[] itemNotes = itemListNotes[i].Split('\n');
                foreach (string itemNote in itemNotes) { // for any note
                    text = itemNote; // add the note
                    e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(x2, y, maxWidth, height), drawLeft);
                    y += e.Graphics.MeasureString(text, SegoeUI10Semibold).Height;
                }
            }

            text = new String('-', 33); // Final divider to signify end of ticket
            e.Graphics.DrawString(text, SegoeUI10Reg, blackBrush, new RectangleF(5, y, maxWidth, height), drawCenter);
            y += e.Graphics.MeasureString(text, SegoeUI10Reg).Height;

            decimal billTotal = 0.0m;

            foreach(decimal price in itemPrice) {
                billTotal += price;
            }

            text = "Total: £" + billTotal.ToString("0.00"); // List item text
            e.Graphics.DrawString(text, SegoeUI8Semibold, blackBrush, new RectangleF(x, y, maxWidth, height), drawRight);
            y += e.Graphics.MeasureString(text, SegoeUI8Semibold).Height;
        }
    }
}
