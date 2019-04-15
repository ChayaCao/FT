


Imports System.Data.SqlClient

Public Class frmProdset



    Private Sub combo_cust_DropDown(sender As Object, e As EventArgs) Handles combo_cust.DropDown
        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select ename from Customer"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Customer")

        If mydataset.Tables("Customer").Rows.Count = 0 Then
            combo_cust.Items.Add("Query Customer List Fail !")
        Else
            combo_cust.Items.Clear()

            'List All customer
            For i = 0 To mydataset.Tables("Customer").Rows.Count - 1
                combo_cust.Items.Add(mydataset.Tables("Customer").Rows(i).Item("ename"))
            Next

        End If


    End Sub

    Private Sub combo_prod_DropDown(sender As Object, e As EventArgs) Handles combo_prod.DropDown


        combo_prod.Items.Clear()
        combo_prod.Items.Add("CIS")
        combo_prod.Items.Add("Driver")
        combo_prod.Items.Add("MEMORY")
        combo_prod.Items.Add("RF")
        combo_prod.Items.Add("Soc")

    End Sub

    Private Sub combo_wsize_DropDown(sender As Object, e As EventArgs)

    End Sub

    Private Sub combo_bund_DropDown(sender As Object, e As EventArgs) Handles combo_bund.DropDown
        combo_bund.Items.Clear()
        combo_bund.Items.Add("TRUE")
        combo_bund.Items.Add("FALSE")
    End Sub

    Private Sub CONFIRM_Click(sender As Object, e As EventArgs) Handles CONFIRM.Click
        Dim mysql As String

        If Product_Operation_Mode = "NEW" Then

            mysql = "INSERT INTO Product (Customer,ProductType,PackageType,Bonded,InternalProduct,CustomerProduct,ShipProduct,RetestFlow,Mark,Enable,CreateTime,Creater) VALUES ( '" &
                combo_cust.Text & "','" & combo_prod.Text & "','" & txt_package.Text & "','" & combo_bund.Text & "','" & txt_iprod.Text & "','" & txt_cprod.Text & "','" &
                 txt_sprod.Text & "','" & txt_retest.Text & "','" & txt_mark.Text & "','TRUE','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Me.Close()

        ElseIf Product_Operation_Mode = "MODIFY" Then

            mysql = "UPDATE  Product SET Customer= '" & combo_cust.Text & "', ProductType='" & combo_prod.Text & "', PackageType='" & txt_package.Text & "', Bonded='" & combo_bund.Text &
                "', CustomerProduct='" & txt_cprod.Text & "', ShipProduct='" & txt_sprod.Text & "', RetestFlow ='" & txt_retest.Text & "', Mark='" & txt_mark.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
                "' WHERE InternalProduct='" & myProduct.InternalProduct & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            Me.Close()

        End If

        Call frmProduct.btn_Query_Click("", e)

    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        Me.Close()
    End Sub

    Private Sub ProductOPSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Left = 10
        Me.Top = 10

        If Product_Operation_Mode = "NEW" Then

        ElseIf Product_Operation_Mode = "MODIFY" Then

            combo_cust.Text = myProduct.Customer
            combo_prod.Text = myProduct.ProductType

            combo_bund.Text = myProduct.Bonded


            txt_iprod.Text = myProduct.InternalProduct
            txt_iprod.ReadOnly = True
            txt_cprod.Text = myProduct.CustomerProduct

            txt_sprod.Text = myProduct.ShipProduct
            txt_retest.Text = myProduct.RetestFlow
            txt_package.Text = myProduct.PackageType



            txt_mark.Text = myProduct.Mark


        End If

        Me.BackColor = mydefaultcolor

    End Sub



End Class