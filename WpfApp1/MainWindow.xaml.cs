using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Mark the event handler with async so you can use await in it.
        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Call and await separately.
            //Task<int> getLengthTask = AccessTheWebAsync();
            //// You can do independent work here.
            //int contentLength = await getLengthTask;

            int contentLength = await AccessTheWebAsync();

            var uithreadId = Thread.CurrentThread.ManagedThreadId;

            resultsTextBox.Text += $"\r\nwait contentLength";

            resultsTextBox.Text +=
                $"\r\nLength of the downloaded string: {contentLength}.\r\n";
        }

        // Three things to note in the signature:
        //  - The method has an async modifier. 
        //  - The return type is Task or Task<T>. (See "Return Types" section.)
        //    Here, it is Task<int> because the return statement returns an integer.
        //  - The method name ends in "Async."
        async Task<int> AccessTheWebAsync()
        {
            // GetStringAsync returns a Task<string>. That means that when you await the
            // task you'll get a string (urlContents).
            Stopwatch st = new Stopwatch();
            st.Start();
            Task<string> getStringTask =  GetStringAsync("https://docs.microsoft.com/dotnet");

            var time1 = st.ElapsedMilliseconds;

            // You can do work here that doesn't rely on the string from GetStringAsync.
            DoIndependentWork();

            var time2 = st.ElapsedMilliseconds;

            // The await operator suspends AccessTheWebAsync.
            //  - AccessTheWebAsync can't continue until getStringTask is complete.
            //  - Meanwhile, control returns to the caller of AccessTheWebAsync.
            //  - Control resumes here when getStringTask is complete. 
            //  - The await operator then retrieves the string result from getStringTask.
            string urlContents = await getStringTask;

            var time3 = st.ElapsedMilliseconds;

            var cc = "";

            // The return statement specifies an integer result.
            // Any methods that are awaiting AccessTheWebAsync retrieve the length value.
            return urlContents.Length;
        }

        void DoIndependentWork()
        {
            Thread.Sleep(3000);
            resultsTextBox.Text += "\r\nWorking . . . . . . .\r\n";
        }

        async Task<string> GetStringAsync(string url)
        {
            var task = await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return $"{Thread.CurrentThread.ManagedThreadId}";
            });
            var cc = 9;
            return task;
        }
    }
}
