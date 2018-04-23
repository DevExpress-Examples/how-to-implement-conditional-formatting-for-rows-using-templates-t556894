Partial Public NotInheritable Class MainPage
    Inherits Page
    Public Sub New()
        Me.InitializeComponent()
        grid.ItemsSource = New Data.ProductList()
    End Sub
End Class

Public Class RowHandleToBackgroundConverter
    Implements IValueConverter
    Public Property EvenRowBackground() As Brush
    Public Property OddRowBackground() As Brush

    Private Function IValueConverter_Convert(value As Object, targetType As Type, parameter As Object, language As String) As Object Implements IValueConverter.Convert
        If (DirectCast(value, Integer) Mod 2) = 0 Then
            Return OddRowBackground
        Else
            Return EvenRowBackground
        End If
    End Function

    Private Function IValueConverter_ConvertBack(value As Object, targetType As Type, parameter As Object, language As String) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
