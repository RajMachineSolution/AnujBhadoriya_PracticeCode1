Public Class OwnProperty
    Private intHeight As Integer
    Private intWidth As Integer
    Public Property ChangeHeight() As Integer

        Get
            ChangeHeight = intHeight
        End Get
        Set(value As Integer)
            intHeight = value
        End Set
    End Property

    Public Property ChangeWidth() As Integer
        Get
            ChangeWidth = intWidth
        End Get
        Set(value As Integer)
            intWidth = value
        End Set
    End Property

End Class
