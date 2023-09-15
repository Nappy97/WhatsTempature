using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void CityTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            // Enter 키가 눌렸을 때 검색 버튼을 클릭합니다.
            Button_Click(sender, e);
        }
    }


    private async void Button_Click(object sender, RoutedEventArgs e)
    {
        // 도시 이름을 TextBox에서 가져옵니다.
        string cityName = cityTextBox.Text;

        // 로딩 화면을 표시합니다.
        loadingProgressBar.Visibility = Visibility.Visible;

        // 5초 동안 대기하는 비동기 작업을 실행합니다.
        await Task.Run(() =>
        {
            Thread.Sleep(5000); // 5초 대기
        });

        // 로딩 화면을 숨깁니다.
        loadingProgressBar.Visibility = Visibility.Collapsed;

        // 도시 이름을 사용하여 메시지를 생성합니다.
        string message = $"{cityName}의 온도는 알 수 없어요\n기상청을 보세요!";

        // MessageBox를 사용하여 메시지를 alert 창으로 표시합니다.
        MessageBox.Show(message, "알림", MessageBoxButton.OK, MessageBoxImage.Information);

    }
}