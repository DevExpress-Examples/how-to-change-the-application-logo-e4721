Namespace CustomLogoExample.Win
    Partial Public Class CustomLogoExampleWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New CustomLogoExample.Module.CustomLogoExampleModule()

            Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlConnection1
            ' 
            Me.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=CustomLogoExample"
            Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' CustomLogoExampleWindowsFormsApplication
            ' 
            Me.ApplicationName = "CustomLogoExample"
            Me.Connection = Me.sqlConnection1
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
'            Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.CustomLogoExampleWindowsFormsApplication_DatabaseVersionMismatch)
'            Me.CustomizeLanguagesList += New System.EventHandler(Of DevExpress.ExpressApp.CustomizeLanguagesListEventArgs)(Me.CustomLogoExampleWindowsFormsApplication_CustomizeLanguagesList)

            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As CustomLogoExample.Module.CustomLogoExampleModule
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    End Class
End Namespace
