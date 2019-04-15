Imports System.Data.SqlClient

Public Class frmStepset


    Private Sub StepDefineForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Step recipe define for    CUSTOMER -> " & myProduct.Customer & ",    PRODUCT -> " & myProduct.InternalProduct
        Me.Left = 10
        Me.Top = 10

        If UserGroup = GROUPTYPE.SU Then
            btn_IQC_delete.Visible = True
            btn_FQC_delete.Visible = True
            btn_ft_delete.Visible = True
            btn_BAKE_delete.Visible = True
            btn_QC_delete.Visible = True
            btn_scanvm_delete.Visible = True
            btn_pack_delete.Visible = True
            btn_ship_delete.Visible = True
            btn_TR_delete.Visible = True

        End If

        Me.BackColor = mydefaultcolor
        Tabcontrol.TabPages(0).BackColor = mydefaultcolor
        Tabcontrol.TabPages(1).BackColor = mydefaultcolor
        Tabcontrol.TabPages(2).BackColor = mydefaultcolor
        Tabcontrol.TabPages(3).BackColor = mydefaultcolor
        Tabcontrol.TabPages(4).BackColor = mydefaultcolor
        Tabcontrol.TabPages(5).BackColor = mydefaultcolor
        Tabcontrol.TabPages(6).BackColor = mydefaultcolor
        Tabcontrol.TabPages(7).BackColor = mydefaultcolor
        Tabcontrol.TabPages(8).BackColor = mydefaultcolor
        combo_ft_stagequery.Items.Add("ALL")
        For i = 1 To 9
            combo_ft_stagequery.Items.Add("FT" & i)
        Next

        combo_QC_stagequery.Items.Add("ALL")
        For i = 1 To 9
            combo_QC_Stage.Items.Add("QC" & i)
        Next

        For i = 1 To 10
            combo_bake_recipe.Items.Add(i)
        Next
        combo_ship_STAGE.Items.Add("SHIP")
        combo_ship_STAGE.Items.Add("OQC")

        combo_SHIP_stagequery.Items.Add("ALL")
        combo_SHIP_stagequery.Items.Add("SHIP")
        combo_SHIP_stagequery.Items.Add("OQC")
        Me.Height = My.Computer.Screen.Bounds.Height * 0.9

    End Sub

    Private Sub ClearPara()

        txt_IQC_id.Text = ""
        txt_IQC_lot.Text = ""
        txt_IQC_SampleSize.Text = ""
        txt_IQC_Remark.Text = ""

        combo_IQC_type.Text = ""

        txt_FQC_ID.Text = ""
        txt_FQC_lot.Text = ""
        txt_FQC_SampleSize.Text = ""

        txt_FQC_stage.Text = ""
        txt_FQC_traystacking.Text = ""
        txt_FQC_Attention.Text = ""
        combo_FQC_type.Text = ""
        txt_FQC_Remark.Text = ""


        txt_ft_id.Text = ""
        combo_ft_STAGE.Text = ""
        combo_ft_type.Text = ""
        txt_ftn_lot.Text = ""
        Combo_ft_auto1.Text = ""
        Combo_ft_auto2.Text = ""
        Combo_ft_auto3.Text = ""
        Combo_ft_FIX1.Text = ""
        Combo_ft_FIX2.Text = ""
        Combo_ft_FIX3.Text = ""
        txt_FT_TestFlatform.Text = ""
        txt_FT_Handler.Text = ""
        txt_FT_SetupFile.Text = ""
        txt_FT_TestMode.Text = ""
        txt_FT_Os.Text = ""
        txt_FT_SWRev.Text = ""
        txt_FT_TestTime.Text = ""


        txt_FT_TestTemp.Text = ""
        txt_FT_SOAKTIME.Text = ""
        txt_FT_LoadBoard.Text = ""
        txt_FT_YieldLimit.Text = ""
        txt_FT_OsLimit.Text = ""
        txt_FT_HighYieldLimit.Text = ""
        txt_FT_OtherSBL.Text = ""
        txt_FTn_attention.Text = ""
        txt_FTn_remark.Text = ""



        txt_BAKE_id.Text = ""

        txt_BAKE_lot.Text = ""
        combo_BAKE_type.Text = ""
        combo_bake_recipe.Text = ""
        txt_bake_temp.Text = ""
        txt_bake_baketime.Text = ""
        txt_bake_remark.Text = ""
        txt_bake_tempgruve.Text = ""
        txt_bake_GasFlow.Text = ""
        txt_bake_bakingtime.Text = ""


        txt_QC_id.Text = ""
        combo_QC_Stage.Text = ""
        txt_QC_lot.Text = ""
        combo_QC_type.Text = ""
        txt_QC_Attention.Text = ""
        txt_QC_Remark.Text = ""
        txt_QC_samplingsize.Text = ""
        Combo_QC_AUTO1.Text = ""
        Combo_QC_AUTO2.Text = ""
        Combo_QC_AUTO3.Text = ""
        Combo_QC_FIX1.Text = ""
        Combo_QC_FIX2.Text = ""
        Combo_QC_FIX3.Text = ""
        txt_QC_TestFlatform.Text = ""
        txt_QC_Handler.Text = ""
        txt_QC_setupfile.Text = ""
        txt_QC_testmode.Text = ""
        txt_QC_os.Text = ""
        txt_QC_swrev.Text = ""
        txt_QC_testtime.Text = ""
        txt_QC_temp.Text = ""
        txt_QC_soaktime.Text = ""
        txt_QC_loadboard.Text = ""






        txt_scanvm_id.Text = ""
        txt_scanvm_lot.Text = ""
        txt_scanvm_scanjob.Text = ""
        txt_scanvm_traystacking.Text = ""
        txt_scanvm_yieldlimit.Text = ""
        txt_scanvm_remark.Text = ""
        combo_scanvm_type.Text = ""
        combo_scanvm_query.Text = ""





        txt_pack_id.Text = ""
        txt_pack_lot.Text = ""
        combo_pack_type.Text = ""
        txt_pack_remark.Text = ""
        txt_pack_packinfo.Text = ""
        txt_pack_packingjob.Text = ""
        txt_pack_traystacking.Text = ""
        txt_pack_msl.Text = ""
        txt_pack_duetime.Text = ""


        txt_ship_id.Text = ""
        txt_ship_lot.Text = ""
        combo_ship_type.Text = ""
        txt_ship_REMARK.Text = ""
        combo_ship_STAGE.Text = ""


        txt_tr_id.Text = ""
        txt_tr_lot.Text = ""
        combo_TR_type.Text = ""
        txt_tr_remark.Text = ""
        txt_tr_trjob.Text = ""
        txt_tr_yieldlimit.Text = ""



    End Sub
    Dim str As String


    ''''''''''''''''''''''''''''''''''''''''
    '''IQC Page Operation
    '''
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_IQC_Query_Click(sender As Object, e As EventArgs) Handles btn_IQC_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_IQC_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_IQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_IQC where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_IQC")

        If mydataset.Tables("Recipe_IQC").Rows.Count = 0 Then
            DGV_IQC.DataSource = Nothing

        Else

            DGV_IQC.DataSource = mydataset.Tables("Recipe_IQC")
            DGV_IQC.Columns(0).Width = COLUMNWIDTH * 1.5

        End If


    End Sub

    Private Sub btn_IQC_new_Click(sender As Object, e As EventArgs) Handles btn_IQC_new.Click

        StepDefine_Mode = "NEW"
        grp_IQC_para.Visible = True
        ClearPara()

    End Sub

    Private Sub btn_IQC_modify_Click(sender As Object, e As EventArgs) Handles btn_IQC_modify.Click


        StepDefine_Mode = "MODIFY"

        If DGV_IQC.Rows.Count = 0 Then Exit Sub

        grp_IQC_para.Visible = True

        txt_IQC_id.Text = DGV_IQC.SelectedRows(0).Cells("ID").Value
        txt_IQC_id.ReadOnly = True
        txt_IQC_lot.Text = DGV_IQC.SelectedRows(0).Cells("Lot").Value
        combo_IQC_type.Text = DGV_IQC.SelectedRows(0).Cells("Type").Value
        txt_IQC_SampleSize.Text = DGV_IQC.SelectedRows(0).Cells("SamplingSize").Value

        txt_IQC_Remark.Text = DGV_IQC.SelectedRows(0).Cells("Remark").Value


    End Sub

    Private Sub btn_iqc_copy_Click(sender As Object, e As EventArgs) Handles btn_iqc_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_IQC.Rows.Count = 0 Then Exit Sub

        grp_IQC_para.Visible = True
        txt_IQC_id.Text = ""
        txt_IQC_lot.Text = DGV_IQC.SelectedRows(0).Cells("Lot").Value
        combo_IQC_type.Text = DGV_IQC.SelectedRows(0).Cells("Type").Value
        txt_IQC_SampleSize.Text = DGV_IQC.SelectedRows(0).Cells("SamplingSize").Value

        txt_IQC_Remark.Text = DGV_IQC.SelectedRows(0).Cells("Remark").Value

    End Sub

    Private Sub btn_IQC_disable_Click(sender As Object, e As EventArgs) Handles btn_IQC_disable.Click

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_IQC.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_IQC SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_IQC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_IQC_Query_Click("", e)

        End If

    End Sub

    Private Sub btn_IQC_delete_Click(sender As Object, e As EventArgs) Handles btn_IQC_delete.Click


        Dim mysql As String, s As Integer

        If DGV_IQC.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_IQC WHERE ID ='" & DGV_IQC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_IQC_Query_Click("", e)

        End If


    End Sub

    Private Sub btn_IQC_cancel_Click(sender As Object, e As EventArgs) Handles btn_IQC_cancel.Click
        Me.Close()
    End Sub

    Private Sub combo_IQC_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_IQC_type.SelectedIndexChanged
        If combo_IQC_type.Text = "SEN" Then
            txt_IQC_lot.ReadOnly = False
            txt_IQC_lot.Text = ""
        ElseIf combo_IQC_type.Text = "ECN" Then
            txt_IQC_lot.ReadOnly = True
            txt_IQC_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_IQC_confirm_Click(sender As Object, e As EventArgs) Handles btn_IQC_confirm.Click

        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_IQC_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If txt_IQC_SampleSize.Text = "" Then
            MsgBox("SampleSize 未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_IQC_type.Text = "ECN" Then

                mysql = "select * from Recipe_IQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_IQC")

                If mydataset.Tables("Recipe_IQC").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

            End If

            '往数据库插入

            If combo_IQC_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_IQC_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_IQC (ID,Customer,InternalProduct,Type,FlowName,Lot,SamplingSize,Remark,ENABLE,CreateTime,Creater) VALUES ( '" &
                ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_IQC_type.Text & "','" & "IQC" & "','" & txt_IQC_lot.Text & "','" &
                txt_IQC_SampleSize.Text & "','" & txt_IQC_Remark.Text & "','TRUE','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_IQC_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_IQC SET LOT= '" & txt_IQC_lot.Text & "',SamplingSize= '" & txt_IQC_SampleSize.Text & "', Remark= '" & txt_IQC_Remark.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_IQC_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_IQC_Query_Click("", e)

            End If

        End If




    End Sub


    ''''''''''''''''''''''''''''''''''''''''
    '''FQC Page Operation
    '''
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_FQC_query_Click(sender As Object, e As EventArgs) Handles btn_FQC_query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_FQC_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_FQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_FQC where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_FQC")

        If mydataset.Tables("Recipe_FQC").Rows.Count = 0 Then
            DGV_FQC.DataSource = Nothing

        Else

            DGV_FQC.DataSource = mydataset.Tables("Recipe_FQC")
            DGV_FQC.Columns(0).Width = COLUMNWIDTH * 1.5

        End If


    End Sub

    Private Sub btn_FQC_new_Click(sender As Object, e As EventArgs) Handles btn_FQC_new.Click

        StepDefine_Mode = "NEW"
        grp_FQC_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_FQC_modify_Click(sender As Object, e As EventArgs) Handles btn_FQC_modify.Click

        StepDefine_Mode = "MODIFY"

        If DGV_FQC.Rows.Count = 0 Then Exit Sub

        grp_FQC_para.Visible = True

        txt_FQC_ID.Text = DGV_FQC.SelectedRows(0).Cells("ID").Value
        txt_FQC_ID.ReadOnly = True
        txt_FQC_lot.Text = DGV_FQC.SelectedRows(0).Cells("Lot").Value
        combo_FQC_type.Text = DGV_FQC.SelectedRows(0).Cells("Type").Value
        txt_FQC_SampleSize.Text = DGV_FQC.SelectedRows(0).Cells("SamplingSize").Value
        txt_FQC_Attention.Text = DGV_FQC.SelectedRows(0).Cells("Attention").Value.ToString
        txt_FQC_stage.Text = DGV_FQC.SelectedRows(0).Cells("STAGE").Value
        txt_FQC_Remark.Text = DGV_FQC.SelectedRows(0).Cells("remark").Value.ToString
        txt_FQC_traystacking.Text = DGV_FQC.SelectedRows(0).Cells("traystacking").Value.ToString

    End Sub

    Private Sub btn_FQC_copy_Click(sender As Object, e As EventArgs) Handles btn_FQC_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_FQC.Rows.Count = 0 Then Exit Sub

        grp_FQC_para.Visible = True

        txt_FQC_ID.Text = ""
        txt_FQC_lot.Text = DGV_FQC.SelectedRows(0).Cells("Lot").Value
        combo_FQC_type.Text = DGV_FQC.SelectedRows(0).Cells("Type").Value
        txt_FQC_SampleSize.Text = DGV_FQC.SelectedRows(0).Cells("SamplingSize").Value
        txt_FQC_Attention.Text = DGV_FQC.SelectedRows(0).Cells("Attention").Value
        txt_FQC_stage.Text = DGV_FQC.SelectedRows(0).Cells("STAGE").Value
        txt_FQC_Remark.Text = DGV_FQC.SelectedRows(0).Cells("remark").Value.ToString
        txt_FQC_traystacking.Text = DGV_FQC.SelectedRows(0).Cells("traystacking").Value.ToString

    End Sub

    Private Sub btn_FQC_disable_Click(sender As Object, e As EventArgs) Handles btn_FQC_disable.Click
        Dim mysql As String, s As Integer


        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


        If s = 1 Then

            If DGV_FQC.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_FQC SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_FQC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("已成功停用!", vbOKOnly + vbInformation)
            Call btn_FQC_query_Click("", e)

        End If

    End Sub

    Private Sub btn_FQC_delete_Click(sender As Object, e As EventArgs) Handles btn_FQC_delete.Click
        Dim mysql As String, s As Integer

        If DGV_FQC.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_FQC WHERE ID ='" & DGV_FQC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_FQC_query_Click("", e)

        End If

    End Sub

    Private Sub btn_FQC_exit_Click(sender As Object, e As EventArgs) Handles btn_FQC_exit.Click
        Me.Close()
    End Sub

    Private Sub combo_FQC_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_FQC_type.SelectedIndexChanged
        If combo_FQC_type.Text = "SEN" Then
            txt_FQC_lot.ReadOnly = False
            txt_FQC_lot.Text = ""
        ElseIf combo_FQC_type.Text = "ECN" Then
            txt_FQC_lot.ReadOnly = True
            txt_FQC_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_FQC_confirm_Click(sender As Object, e As EventArgs) Handles btn_FQC_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_FQC_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If txt_FQC_stage.Text = "" Or
                txt_FQC_traystacking.Text = "" Or
                txt_FQC_SampleSize.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_FQC_type.Text = "ECN" Then
                mysql = "select * from Recipe_FQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_FQC")

                If mydataset.Tables("Recipe_FQC").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_FQC_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_FQC_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_FQC (ID,Customer,InternalProduct,Type,FlowName,Lot,traystacking,SamplingSize,Attention,ENABLE,remark,CreateTime,Creater) VALUES ( '" &
                ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_FQC_type.Text & "','" & "FQC" & "','" & txt_FQC_lot.Text & "','" & txt_FQC_traystacking.Text & "','" &
            txt_FQC_SampleSize.Text & "','" & txt_FQC_Attention.Text & "','TRUE','" & txt_FQC_Remark.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_FQC_query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_FQC SET LOT= '" & txt_FQC_lot.Text &
                    "',SamplingSize= '" & txt_FQC_SampleSize.Text &
                    "',Attention= '" & txt_FQC_Attention.Text &
                    "', STAGE= '" & txt_FQC_stage.Text &
                    "',remark='" & txt_FQC_Remark.Text &
                    "',traystacking='" & txt_FQC_traystacking.Text &
                    "', ModifyTime='" & Now &
                    "',Modifier= '" & UserID &
                    "' WHERE ID= '" & txt_FQC_ID.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()
                MsgBox("已成功修改!", vbOKOnly + vbInformation)
                ClearPara()
                Call btn_FQC_query_Click("", e)

            End If

        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''
    '''FT Page Operation
    '''
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_CP_Query_Click(sender As Object, e As EventArgs) Handles btn_ft_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        Select Case combo_ft_enable.Text
            Case "ENABLE"
                If combo_ft_stagequery.Text = "ALL" Then
                    mysql = "select * from Recipe_FT where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
                Else
                    mysql = "select * from Recipe_FT where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND STAGE='" & combo_ft_stagequery.Text & "'"
                End If

            Case "ALL"
                If combo_ft_stagequery.Text = "ALL" Then
                    mysql = "select * from Recipe_FT where InternalProduct='" & myProduct.InternalProduct & "'"
                Else
                    mysql = "select * from Recipe_FT where InternalProduct='" & myProduct.InternalProduct & "'AND STAGE='" & combo_ft_stagequery.Text & "'"
                End If

        End Select
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Recipe_FT")

        If mydataset.Tables("Recipe_FT").Rows.Count = 0 Then
            DGV_FT.DataSource = Nothing
        Else
            DGV_FT.DataSource = mydataset.Tables("Recipe_FT")
            DGV_FT.Columns(0).Width = COLUMNWIDTH * 1.5

        End If

    End Sub

    Private Sub btn_CP_new_Click(sender As Object, e As EventArgs) Handles btn_ft_new.Click

        StepDefine_Mode = "NEW"
        grp_CP_para.Visible = True
        ClearPara()

    End Sub

    Private Sub btn_CP_modify_Click(sender As Object, e As EventArgs) Handles btn_ft_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_FT.Rows.Count = 0 Then Exit Sub

        grp_CP_para.Visible = True

        txt_ft_id.Text = DGV_FT.SelectedRows(0).Cells("ID").Value
        txt_ft_id.ReadOnly = True

        combo_ft_STAGE.Text = DGV_FT.SelectedRows(0).Cells("Stage").Value
        combo_ft_type.Text = DGV_FT.SelectedRows(0).Cells("Type").Value
        txt_ftn_lot.Text = DGV_FT.SelectedRows(0).Cells("Lot").Value


        Combo_ft_auto1.Text = DGV_FT.SelectedRows(0).Cells("AUTO1").Value
        Combo_ft_auto2.Text = DGV_FT.SelectedRows(0).Cells("AUTO2").Value
        Combo_ft_auto3.Text = DGV_FT.SelectedRows(0).Cells("AUTO3").Value
        Combo_ft_FIX1.Text = DGV_FT.SelectedRows(0).Cells("FIX1").Value
        Combo_ft_FIX2.Text = DGV_FT.SelectedRows(0).Cells("FIX2").Value
        Combo_ft_FIX3.Text = DGV_FT.SelectedRows(0).Cells("FIX3").Value
        txt_FT_TestFlatform.Text = DGV_FT.SelectedRows(0).Cells("TestFlatform").Value
        txt_FT_Handler.Text = DGV_FT.SelectedRows(0).Cells("Handler").Value
        txt_FT_SetupFile.Text = DGV_FT.SelectedRows(0).Cells("HandlerSetupFile").Value
        txt_FT_TestMode.Text = DGV_FT.SelectedRows(0).Cells("TestMode").Value
        txt_FT_Os.Text = DGV_FT.SelectedRows(0).Cells("Os").Value
        txt_FT_SWRev.Text = DGV_FT.SelectedRows(0).Cells("SWRev").Value
        txt_FT_TestTime.Text = DGV_FT.SelectedRows(0).Cells("TestTime").Value
        txt_FT_TestTemp.Text = DGV_FT.SelectedRows(0).Cells("TEMP").Value
        txt_FT_SOAKTIME.Text = DGV_FT.SelectedRows(0).Cells("SOAKTIME").Value
        txt_FT_LoadBoard.Text = DGV_FT.SelectedRows(0).Cells("LoadBoard").Value
        txt_FT_YieldLimit.Text = DGV_FT.SelectedRows(0).Cells("YieldLimit").Value
        txt_FT_OsLimit.Text = DGV_FT.SelectedRows(0).Cells("OsLimit").Value
        txt_FT_HighYieldLimit.Text = DGV_FT.SelectedRows(0).Cells("HighYieldLimit").Value
        txt_FT_OtherSBL.Text = DGV_FT.SelectedRows(0).Cells("OtherSBL").Value
        txt_FTn_attention.Text = DGV_FT.SelectedRows(0).Cells("Attention").Value
        txt_FTn_remark.Text = DGV_FT.SelectedRows(0).Cells("Remark").Value

    End Sub


    Private Sub btn_CP_copy_Click(sender As Object, e As EventArgs) Handles btn_ft_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_FT.Rows.Count = 0 Then Exit Sub

        grp_CP_para.Visible = True

        txt_ft_id.Text = ""

        combo_ft_STAGE.Text = DGV_FT.SelectedRows(0).Cells("Stage").Value
        combo_ft_type.Text = DGV_FT.SelectedRows(0).Cells("Type").Value
        txt_ftn_lot.Text = DGV_FT.SelectedRows(0).Cells("Lot").Value


        Combo_ft_auto1.Text = DGV_FT.SelectedRows(0).Cells("AUTO1").Value
        Combo_ft_auto2.Text = DGV_FT.SelectedRows(0).Cells("AUTO2").Value
        Combo_ft_auto3.Text = DGV_FT.SelectedRows(0).Cells("AUTO3").Value
        Combo_ft_FIX1.Text = DGV_FT.SelectedRows(0).Cells("FIX1").Value
        Combo_ft_FIX2.Text = DGV_FT.SelectedRows(0).Cells("FIX2").Value
        Combo_ft_FIX3.Text = DGV_FT.SelectedRows(0).Cells("FIX3").Value
        txt_FT_TestFlatform.Text = DGV_FT.SelectedRows(0).Cells("TestFlatform").Value
        txt_FT_Handler.Text = DGV_FT.SelectedRows(0).Cells("Handler").Value
        txt_FT_SetupFile.Text = DGV_FT.SelectedRows(0).Cells("HandlerSetupFile").Value
        txt_FT_TestMode.Text = DGV_FT.SelectedRows(0).Cells("TestMode").Value
        txt_FT_Os.Text = DGV_FT.SelectedRows(0).Cells("Os").Value
        txt_FT_SWRev.Text = DGV_FT.SelectedRows(0).Cells("SWRev").Value
        txt_FT_TestTime.Text = DGV_FT.SelectedRows(0).Cells("TestTime").Value
        txt_FT_TestTemp.Text = DGV_FT.SelectedRows(0).Cells("TEMP").Value
        txt_FT_SOAKTIME.Text = DGV_FT.SelectedRows(0).Cells("SOAKTIME").Value
        txt_FT_LoadBoard.Text = DGV_FT.SelectedRows(0).Cells("LoadBoard").Value
        txt_FT_YieldLimit.Text = DGV_FT.SelectedRows(0).Cells("YieldLimit").Value
        txt_FT_OsLimit.Text = DGV_FT.SelectedRows(0).Cells("OsLimit").Value
        txt_FT_HighYieldLimit.Text = DGV_FT.SelectedRows(0).Cells("HighYieldLimit").Value
        txt_FT_OtherSBL.Text = DGV_FT.SelectedRows(0).Cells("OtherSBL").Value
        txt_FTn_attention.Text = DGV_FT.SelectedRows(0).Cells("Attention").Value
        txt_FTn_remark.Text = DGV_FT.SelectedRows(0).Cells("Remark").Value



    End Sub


    Private Sub combo_cp_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_ft_type.SelectedIndexChanged
        If combo_ft_type.Text = "SEN" Then
            txt_ftn_lot.ReadOnly = False
            txt_ftn_lot.Text = ""
        ElseIf combo_ft_type.Text = "ECN" Then
            txt_ftn_lot.ReadOnly = True
            txt_ftn_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_CP_disable_Click(sender As Object, e As EventArgs) Handles btn_ft_disable.Click
        Dim mysql As String, s As Integer


        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


        If s = 1 Then

            If DGV_FT.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_CP SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_FT.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_CP_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_CP_delete_Click(sender As Object, e As EventArgs) Handles btn_ft_delete.Click
        Dim mysql As String, s As Integer

        If DGV_FT.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_FT WHERE ID ='" & DGV_FT.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_CP_Query_Click("", e)

        End If
    End Sub


    Private Sub btn_CP_confirm_Click(sender As Object, e As EventArgs) Handles btn_cp_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_ft_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If combo_ft_STAGE.Text = "" Or
                Combo_ft_auto1.Text = "" Or
                Combo_ft_auto2.Text = "" Or
                Combo_ft_auto3.Text = "" Or
                Combo_ft_FIX1.Text = "" Or
                Combo_ft_FIX2.Text = "" Or
                Combo_ft_FIX3.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If txt_FT_TestTime.Text = "" Or
                txt_FT_TestFlatform.Text = "" Or
                txt_FT_Handler.Text = "" Or
                txt_FT_SetupFile.Text = "" Or
                txt_FT_TestMode.Text = "" Or
                txt_FT_Os.Text = "" Or
                txt_FT_SWRev.Text = "" Or
                txt_FT_TestTime.Text = "" Or
                txt_FT_TestTemp.Text = "" Or
                txt_FT_SOAKTIME.Text = "" Or
                txt_FT_LoadBoard.Text = "" Or
                txt_FT_YieldLimit.Text = "" Or
                txt_FT_OsLimit.Text = "" Or
                txt_FT_HighYieldLimit.Text = "" Or
                txt_FT_OtherSBL.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If Not IsNumeric(txt_FT_TestTime.Text & txt_FT_SOAKTIME.Text & txt_FT_HighYieldLimit.Text & txt_FT_OsLimit.Text & txt_FT_OtherSBL.Text & txt_FT_YieldLimit.Text) Then
            MsgBox("testtime/soaktime/HighYieldLimit/OsLimit/OtherSBL/YieldLimit须输入数字!", vbOKOnly + vbExclamation)
            Exit Sub
        End If



        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_ft_type.Text = "ECN" Then
                mysql = "select * from Recipe_FT where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN' AND Stage='" & combo_ft_STAGE.Text & "'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_FT")

                If mydataset.Tables("Recipe_FT").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_ft_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_ft_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_FT (ID,customer,InternalProduct,Stage,Type,ENABLE,Lot,AUTO1,AUTO2,AUTO3,FIX1,FIX2,FIX3,
            TestFlatform,Handler,HandlerSetupFile,TestMode,TestTime,
            Os,SWRev,TEMP,SOAKTIME,LoadBoard,YieldLimit,OsLimit,HighYieldLimit,OtherSBL,Attention,Remark
                     ,CreateTime,Creater) VALUES ( 
           '" &
            ID & "','" &
            myProduct.Customer & "','" &
            myProduct.InternalProduct & "','" &
            combo_ft_STAGE.Text & "','" &
            combo_ft_type.Text & "','TRUE','" &
            txt_ftn_lot.Text & " ','" &
            Combo_ft_auto1.Text & "','" &
            Combo_ft_auto2.Text & "','" &
            Combo_ft_auto3.Text & "','" &
            Combo_ft_FIX1.Text & "','" &
            Combo_ft_FIX2.Text & "','" &
            Combo_ft_FIX3.Text & "','" &
            txt_FT_TestFlatform.Text & "','" &
            txt_FT_Handler.Text & "','" &
            txt_FT_SetupFile.Text & "','" &
            txt_FT_TestMode.Text & "','" &
            txt_FT_TestTime.Text & "','" &
            txt_FT_Os.Text & "','" &
            txt_FT_SWRev.Text & "','" &
            txt_FT_TestTemp.Text & "','" &
            txt_FT_SOAKTIME.Text & "','" &
            txt_FT_LoadBoard.Text & "','" &
            txt_FT_YieldLimit.Text & "','" &
            txt_FT_OsLimit.Text & "','" &
            txt_FT_HighYieldLimit.Text & "','" &
            txt_FT_OtherSBL.Text & "','" &
            txt_FTn_attention.Text & "','" &
            txt_FTn_remark.Text & "','" & Now & "','" & UserID & "')"



            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_CP_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_FT SET LOT= '" & txt_ftn_lot.Text &
                    "',Stage= '" & combo_ft_STAGE.Text &
                    "',Type= '" & combo_ft_type.Text &
                    "',AUTO1= '" & Combo_ft_auto1.Text &
                    "', AUTO2= '" & Combo_ft_auto2.Text &
                    "',AUTO3='" & Combo_ft_auto3.Text &
                    "',FIX1='" & Combo_ft_FIX1.Text &
                "',FIX2='" & Combo_ft_FIX2.Text &
                "',FIX3='" & Combo_ft_FIX3.Text &
                "',TestFlatform='" & txt_FT_TestFlatform.Text &
                "',Handler='" & txt_FT_Handler.Text &
                "',HandlerSetupFile='" & txt_FT_SetupFile.Text &
                "',TestMode='" & txt_FT_TestMode.Text &
                 "',Os='" & txt_FT_Os.Text &
                 "',SWRev='" & txt_FT_SWRev.Text &
                 "',TestTime='" & txt_FT_TestTime.Text &
                 "',TEMP='" & txt_FT_TestTemp.Text &
                 "',SOAKTIME='" & txt_FT_SOAKTIME.Text &
                 "',LoadBoard='" & txt_FT_LoadBoard.Text &
                 "',YieldLimit='" & txt_FT_YieldLimit.Text &
                 "',OsLimit='" & txt_FT_OsLimit.Text &
                 "',HighYieldLimit='" & txt_FT_HighYieldLimit.Text &
                 "',OtherSBL='" & txt_FT_OtherSBL.Text &
                 "',Attention='" & txt_FTn_attention.Text &
                 "',Remark='" & txt_FTn_remark.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_ft_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_CP_Query_Click("", e)

            End If

        End If
    End Sub

    Private Sub btn_cp_exit_Click(sender As Object, e As EventArgs) Handles btn_cp_exit.Click
        Me.Close()
    End Sub







    ''''''''''''''''''''''''''''''''''''''''
    '''BAKE Page Operation
    '''
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_BAKE_Query_Click(sender As Object, e As EventArgs) Handles btn_BAKE_Query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        Select Case combo_BAKE_query.Text
            Case "ENABLE"

                'If combo_bake_flowquery.Text = "ALL" Then
                mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
                'Else
                '    mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND FlowName='" & combo_bake_flowquery.Text & "'"
                'End If

            Case "ALL"
                'If combo_bake_flowquery.Text = "ALL" Then
                mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'"
                'Else
                '    mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'AND FlowName='" & combo_bake_flowquery.Text & "'"
                'End If

        End Select


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_BAKE")

        If mydataset.Tables("Recipe_BAKE").Rows.Count = 0 Then
            DGV_BAKE.DataSource = Nothing

        Else

            DGV_BAKE.DataSource = mydataset.Tables("Recipe_BAKE")
            DGV_BAKE.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_BAKE_new_Click(sender As Object, e As EventArgs) Handles btn_BAKE_new.Click
        StepDefine_Mode = "NEW"
        grp_bake_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_BAKE_modify_Click(sender As Object, e As EventArgs) Handles btn_BAKE_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_BAKE.Rows.Count = 0 Then Exit Sub

        grp_bake_para.Visible = True

        txt_BAKE_id.Text = DGV_BAKE.SelectedRows(0).Cells("ID").Value
        txt_BAKE_id.ReadOnly = True


        combo_BAKE_type.Text = DGV_BAKE.SelectedRows(0).Cells("Type").Value
        txt_BAKE_lot.Text = DGV_BAKE.SelectedRows(0).Cells("Lot").Value
        txt_bake_bakingtime.Text = DGV_BAKE.SelectedRows(0).Cells("BakingTime").Value
        combo_bake_recipe.Text = DGV_BAKE.SelectedRows(0).Cells("Recipe").Value
        txt_bake_temp.Text = DGV_BAKE.SelectedRows(0).Cells("Temperature").Value
        txt_bake_baketime.Text = DGV_BAKE.SelectedRows(0).Cells("BakeTime").Value
        txt_bake_remark.Text = DGV_BAKE.SelectedRows(0).Cells("Remark").Value.ToString

        txt_bake_tempgruve.Text = DGV_BAKE.SelectedRows(0).Cells("Temperature").Value
        txt_bake_GasFlow.Text = DGV_BAKE.SelectedRows(0).Cells("gasflow").Value

    End Sub

    Private Sub btn_BAKE_copy_Click(sender As Object, e As EventArgs) Handles btn_BAKE_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_BAKE.Rows.Count = 0 Then Exit Sub

        grp_bake_para.Visible = True

        txt_BAKE_id.Text = ""


        combo_BAKE_type.Text = DGV_BAKE.SelectedRows(0).Cells("Type").Value
        txt_BAKE_lot.Text = DGV_BAKE.SelectedRows(0).Cells("Lot").Value
        txt_bake_bakingtime.Text = DGV_BAKE.SelectedRows(0).Cells("BakingTime").Value
        combo_bake_recipe.Text = DGV_BAKE.SelectedRows(0).Cells("Recipe").Value
        txt_bake_temp.Text = DGV_BAKE.SelectedRows(0).Cells("Temperature").Value
        txt_bake_baketime.Text = DGV_BAKE.SelectedRows(0).Cells("BakeTime").Value
        txt_bake_remark.Text = DGV_BAKE.SelectedRows(0).Cells("Remark").Value.ToString

        txt_bake_tempgruve.Text = DGV_BAKE.SelectedRows(0).Cells("Temperature").Value
        txt_bake_GasFlow.Text = DGV_BAKE.SelectedRows(0).Cells("gasflow").Value


    End Sub

    Private Sub combo_BAKE_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_BAKE_type.SelectedIndexChanged
        If combo_BAKE_type.Text = "SEN" Then
            txt_BAKE_lot.ReadOnly = False
            txt_BAKE_lot.Text = ""
        ElseIf combo_BAKE_type.Text = "ECN" Then
            txt_BAKE_lot.ReadOnly = True
            txt_BAKE_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_BAKE_disable_Click(sender As Object, e As EventArgs) Handles btn_BAKE_disable.Click
        Dim mysql As String, s As Integer


        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


        If s = 1 Then

            If DGV_BAKE.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_BAKE SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_BAKE.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("已成功停用!", vbOKOnly + vbInformation)
            Call btn_BAKE_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_BAKE_delete_Click(sender As Object, e As EventArgs) Handles btn_BAKE_delete.Click
        Dim mysql As String, s As Integer

        If DGV_BAKE.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_BAKE WHERE ID ='" & DGV_BAKE.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_BAKE_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_bake_confirm_Click(sender As Object, e As EventArgs) Handles btn_bake_confirm.Click

        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_BAKE_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If combo_bake_recipe.Text = "" Or
                txt_bake_temp.Text = "" Or
                txt_bake_baketime.Text = "" Or
                txt_bake_bakingtime.Text = "" Or
                txt_bake_tempgruve.Text = "" Or
                txt_bake_GasFlow.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If Not IsNumeric(txt_bake_temp.Text & txt_bake_baketime.Text & txt_bake_bakingtime.Text) Then
            MsgBox("温度/时间/时效须输入数字!", vbOKOnly + vbExclamation)
            Exit Sub
        End If




        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_BAKE_type.Text = "ECN" Then
                mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_BAKE")

                If mydataset.Tables("Recipe_BAKE").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_BAKE_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_BAKE_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_BAKE (ID,customer,InternalProduct,Stage,Type,ENABLE,Lot,Recipe,Temperature,BakeTime,tempgurve,gasflow,Remark,BakingTime,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','BAKE','" & combo_BAKE_type.Text & "','TRUE','" & txt_BAKE_lot.Text & " ','" & combo_bake_recipe.Text & " ','" &
            txt_bake_temp.Text & "','" &
            txt_bake_baketime.Text & "','" &
            txt_bake_tempgruve.Text & "','" &
            txt_bake_GasFlow.Text & "','" &
            txt_bake_remark.Text & "','" &
            txt_bake_bakingtime.Text & "','" &
            Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_BAKE_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_BAKE SET LOT= '" & txt_BAKE_lot.Text &
                    "',Recipe= '" & combo_bake_recipe.Text &
                    "',tempgurve= '" & txt_bake_tempgruve.Text &
                    "',gasflow= '" & txt_bake_GasFlow.Text &
                    "',BakingTime= '" & txt_bake_bakingtime.Text &
                    "',Temperature= '" & txt_bake_temp.Text &
                    "', BakeTime= '" & txt_bake_baketime.Text &
                    "',Remark='" & txt_bake_remark.Text &
                 "', ModifyTime='" & Now &
                 "',Modifier= '" & UserID &
                 "' WHERE ID= '" & txt_BAKE_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_BAKE_Query_Click("", e)

            End If

        End If


    End Sub

    Private Sub btn_bake_exit_Click(sender As Object, e As EventArgs) Handles btn_bake_exit.Click
        Me.Close()

    End Sub






    ''''''''''''''''''''''''''''''''''''''''
    '''QC Page Operation
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_cpdt_Query_Click(sender As Object, e As EventArgs) Handles btn_QC_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        Select Case combo_QC_enable.Text

            Case "ENABLE"

                If combo_QC_stagequery.Text = "ALL" Then
                    mysql = "select * from Recipe_QC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
                Else
                    mysql = "select * from Recipe_QC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND STAGE='" & combo_QC_stagequery.Text & "'"
                End If

            Case "ALL"
                If combo_QC_stagequery.Text = "ALL" Then
                    mysql = "select * from Recipe_QC where InternalProduct='" & myProduct.InternalProduct & "'"
                Else
                    mysql = "select * from Recipe_QC where InternalProduct='" & myProduct.InternalProduct & "'AND FlowName='" & combo_QC_stagequery.Text & "'"
                End If

        End Select


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_QC")

        If mydataset.Tables("Recipe_QC").Rows.Count = 0 Then
            DGV_QC.DataSource = Nothing

        Else

            DGV_QC.DataSource = mydataset.Tables("Recipe_QC")
            DGV_QC.Columns(0).Width = COLUMNWIDTH * 1.5

        End If




    End Sub

    Private Sub btn_cpdt_new_Click(sender As Object, e As EventArgs) Handles btn_QC_new.Click
        StepDefine_Mode = "NEW"
        grp_cpdt_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_cpdt_modify_Click(sender As Object, e As EventArgs) Handles btn_QC_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_QC.Rows.Count = 0 Then Exit Sub

        grp_cpdt_para.Visible = True

        txt_QC_id.Text = DGV_QC.SelectedRows(0).Cells("ID").Value
        txt_QC_id.ReadOnly = True
        combo_QC_Stage.Text = DGV_QC.SelectedRows(0).Cells("STAGE").Value
        combo_QC_type.Text = DGV_QC.SelectedRows(0).Cells("Type").Value
        txt_QC_lot.Text = DGV_QC.SelectedRows(0).Cells("Lot").Value


        txt_QC_Attention.Text = DGV_QC.SelectedRows(0).Cells("Attention").Value
        txt_QC_Remark.Text = DGV_QC.SelectedRows(0).Cells("Remark").Value



        txt_QC_samplingsize.Text = DGV_QC.SelectedRows(0).Cells("SamplingSize").Value


        Combo_QC_AUTO1.Text = DGV_QC.SelectedRows(0).Cells("AUTO1").Value
        Combo_QC_AUTO2.Text = DGV_QC.SelectedRows(0).Cells("AUTO2").Value
        Combo_QC_AUTO3.Text = DGV_QC.SelectedRows(0).Cells("AUTO3").Value
        Combo_QC_FIX1.Text = DGV_QC.SelectedRows(0).Cells("FIX1").Value
        Combo_QC_FIX2.Text = DGV_QC.SelectedRows(0).Cells("FIX2").Value
        Combo_QC_FIX3.Text = DGV_QC.SelectedRows(0).Cells("FIX3").Value

        txt_QC_TestFlatform.Text = DGV_QC.SelectedRows(0).Cells("TestFlatform").Value
        txt_QC_Handler.Text = DGV_QC.SelectedRows(0).Cells("Handler").Value
        txt_QC_setupfile.Text = DGV_QC.SelectedRows(0).Cells("HandlerSetupFile").Value
        txt_QC_testmode.Text = DGV_QC.SelectedRows(0).Cells("TestMode").Value
        txt_QC_os.Text = DGV_QC.SelectedRows(0).Cells("Os").Value
        txt_QC_swrev.Text = DGV_QC.SelectedRows(0).Cells("SWRev").Value
        txt_QC_testtime.Text = DGV_QC.SelectedRows(0).Cells("TestTime").Value
        txt_QC_temp.Text = DGV_QC.SelectedRows(0).Cells("TEMP").Value
        txt_QC_soaktime.Text = DGV_QC.SelectedRows(0).Cells("SOAKTIME").Value
        txt_QC_loadboard.Text = DGV_QC.SelectedRows(0).Cells("LoadBoard").Value


    End Sub

    Private Sub btn_cpdt_copy_Click(sender As Object, e As EventArgs) Handles btn_QC_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_QC.Rows.Count = 0 Then Exit Sub

        grp_cpdt_para.Visible = True

        txt_QC_id.Text = ""

        combo_QC_Stage.Text = DGV_QC.SelectedRows(0).Cells("STAGE").Value
        combo_QC_type.Text = DGV_QC.SelectedRows(0).Cells("Type").Value
        txt_QC_lot.Text = DGV_QC.SelectedRows(0).Cells("Lot").Value


        txt_QC_Attention.Text = DGV_QC.SelectedRows(0).Cells("Attention").Value
        txt_QC_Remark.Text = DGV_QC.SelectedRows(0).Cells("Remark").Value



        txt_QC_samplingsize.Text = DGV_QC.SelectedRows(0).Cells("SamplingSize").Value


        Combo_QC_AUTO1.Text = DGV_QC.SelectedRows(0).Cells("AUTO1").Value
        Combo_QC_AUTO2.Text = DGV_QC.SelectedRows(0).Cells("AUTO2").Value
        Combo_QC_AUTO3.Text = DGV_QC.SelectedRows(0).Cells("AUTO3").Value
        Combo_QC_FIX1.Text = DGV_QC.SelectedRows(0).Cells("FIX1").Value
        Combo_QC_FIX2.Text = DGV_QC.SelectedRows(0).Cells("FIX2").Value
        Combo_QC_FIX3.Text = DGV_QC.SelectedRows(0).Cells("FIX3").Value

        txt_QC_TestFlatform.Text = DGV_QC.SelectedRows(0).Cells("TestFlatform").Value
        txt_QC_Handler.Text = DGV_QC.SelectedRows(0).Cells("Handler").Value
        txt_QC_setupfile.Text = DGV_QC.SelectedRows(0).Cells("HandlerSetupFile").Value
        txt_QC_testmode.Text = DGV_QC.SelectedRows(0).Cells("TestMode").Value
        txt_QC_os.Text = DGV_QC.SelectedRows(0).Cells("Os").Value
        txt_QC_swrev.Text = DGV_QC.SelectedRows(0).Cells("SWRev").Value
        txt_QC_testtime.Text = DGV_QC.SelectedRows(0).Cells("TestTime").Value
        txt_QC_temp.Text = DGV_QC.SelectedRows(0).Cells("TEMP").Value
        txt_QC_soaktime.Text = DGV_QC.SelectedRows(0).Cells("SOAKTIME").Value
        txt_QC_loadboard.Text = DGV_QC.SelectedRows(0).Cells("LoadBoard").Value


    End Sub

    Private Sub combo_cpdt_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_QC_type.SelectedIndexChanged
        If combo_QC_type.Text = "SEN" Then
            txt_QC_lot.ReadOnly = False
            txt_QC_lot.Text = ""
        ElseIf combo_QC_type.Text = "ECN" Then
            txt_QC_lot.ReadOnly = True
            txt_QC_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_cpdt_disable_Click(sender As Object, e As EventArgs) Handles btn_QC_disable.Click
        Dim mysql As String, s As Integer


        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


        If s = 1 Then

            If DGV_QC.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_QC SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_QC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_cpdt_Query_Click("", e)

        End If

    End Sub

    Private Sub btn_cpdt_delete_Click(sender As Object, e As EventArgs) Handles btn_QC_delete.Click
        Dim mysql As String, s As Integer

        If DGV_QC.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_QC WHERE ID ='" & DGV_QC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_cpdt_Query_Click("", e)

        End If
    End Sub

    Private Sub txt_cpdt_exit_Click(sender As Object, e As EventArgs) Handles txt_QC_exit.Click
        Me.Close()
    End Sub

    Private Sub txt_cpdt_confirm_Click(sender As Object, e As EventArgs) Handles txt_QC_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_QC_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If combo_QC_Stage.Text = "" Or
                Combo_QC_AUTO1.Text = "" Or
                Combo_QC_AUTO2.Text = "" Or
                Combo_QC_AUTO3.Text = "" Or
                Combo_QC_FIX1.Text = "" Or
                Combo_QC_FIX2.Text = "" Or
                Combo_QC_FIX3.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If txt_FT_TestTime.Text = "" Or
                txt_QC_TestFlatform.Text = "" Or
                txt_QC_Handler.Text = "" Or
                txt_QC_setupfile.Text = "" Or
                txt_QC_testmode.Text = "" Or
                txt_QC_os.Text = "" Or
                txt_QC_swrev.Text = "" Or
                txt_QC_testtime.Text = "" Or
                txt_QC_temp.Text = "" Or
                txt_QC_soaktime.Text = "" Or
                txt_QC_loadboard.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If Not IsNumeric(txt_QC_testtime.Text & txt_QC_soaktime.Text) Then
            MsgBox("testtime/soaktime须输入数字!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        If IsNumeric(txt_QC_testtime.Text & txt_QC_temp.Text & txt_QC_soaktime.Text) Then
            MsgBox("请输入数字!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_QC_type.Text = "ECN" Then
                mysql = "select * from Recipe_QC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN' AND STAGE='" & combo_QC_Stage.Text & "'"
                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_QC")

                If mydataset.Tables("Recipe_QC").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_QC_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_QC_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")
            mysql = "INSERT INTO Recipe_QC (ID,customer,InternalProduct,STAGE,Type,ENABLE,Lot,AUTO1,AUTO2,AUTO3,FIX1,FIX2,FIX3,
            TestFlatform,Handler,HandlerSetupFile,TestMode,TestTime,
            Os,SWRev,TEMP,SOAKTIME,LoadBoard,SamplingSize,Attention,Remark
                     ,CreateTime,Creater) VALUES ( '" &
            ID & "','" &
            myProduct.Customer & "','" &
            myProduct.InternalProduct & "','" &
            combo_QC_Stage.Text & "','" &
            combo_QC_type.Text & "','TRUE','" &
            txt_QC_lot.Text & " ','" &
            Combo_QC_AUTO1.Text & "','" &
            Combo_QC_AUTO2.Text & "','" &
            Combo_QC_AUTO3.Text & "','" &
            Combo_QC_FIX1.Text & "','" &
            Combo_QC_FIX2.Text & "','" &
            Combo_QC_FIX3.Text & "','" &
            txt_QC_TestFlatform.Text & "','" &
            txt_QC_Handler.Text & "','" &
            txt_QC_setupfile.Text & "','" &
            txt_QC_testmode.Text & "','" &
            txt_QC_testtime.Text & "','" &
            txt_QC_os.Text & "','" &
            txt_QC_swrev.Text & "','" &
            txt_QC_temp.Text & "','" &
            txt_QC_soaktime.Text & "','" &
            txt_QC_loadboard.Text & "','" &
            txt_QC_samplingsize.Text & "','" &
            txt_QC_Attention.Text & "','" &
            txt_QC_Remark.Text & "','" & Now & "','" & UserID & "')"




            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_cpdt_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then
                mysql = "UPDATE Recipe_QC SET LOT= '" & txt_QC_lot.Text &
                    "',STAGE= '" & combo_QC_Stage.Text &
                    "',Type= '" & combo_QC_type.Text &
                    "',AUTO1= '" & Combo_QC_AUTO1.Text &
                    "', AUTO2= '" & Combo_QC_AUTO2.Text &
                    "',AUTO3='" & Combo_QC_AUTO3.Text &
                    "',FIX1='" & Combo_QC_FIX2.Text &
                "',FIX2='" & Combo_QC_FIX2.Text &
                "',FIX3='" & Combo_QC_FIX3.Text &
                "',TestFlatform='" & txt_QC_TestFlatform.Text &
                "',Handler='" & txt_QC_Handler.Text &
                "',HandlerSetupFile='" & txt_QC_setupfile.Text &
                "',TestMode='" & txt_QC_testmode.Text &
                 "',Os='" & txt_QC_os.Text &
                 "',SWRev='" & txt_QC_swrev.Text &
                 "',TestTime='" & txt_QC_testtime.Text &
                 "',TEMP='" & txt_QC_temp.Text &
                 "',SOAKTIME='" & txt_QC_soaktime.Text &
                 "',LoadBoard='" & txt_QC_loadboard.Text &
                 "',SamplingSize='" & txt_QC_samplingsize.Text &
                 "',Attention='" & txt_QC_Attention.Text &
                 "',Remark='" & txt_QC_Remark.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_QC_id.Text & "'"


                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_cpdt_Query_Click("", e)

            End If

        End If

    End Sub


    ''''''''''''''''''''''''''''''''''''''''
    '''scanvm Page Operation
    ''''''''''''''''''''''''''''''''''''''''
    '''
    Private Sub btn_wipfs_Query_Click(sender As Object, e As EventArgs) Handles btn_scanvm_Query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_scanvm_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_SCANVM where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_SCANVM where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_SCANVM")

        If mydataset.Tables("Recipe_SCANVM").Rows.Count = 0 Then
            DGV_scanvm.DataSource = Nothing

        Else

            DGV_scanvm.DataSource = mydataset.Tables("Recipe_SCANVM")
            DGV_scanvm.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_wipfs_new_Click(sender As Object, e As EventArgs) Handles btn_scanvm_new.Click
        StepDefine_Mode = "NEW"
        grp_wipfs_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_wipfs_modify_Click(sender As Object, e As EventArgs) Handles btn_scanvm_modify.Click

        StepDefine_Mode = "MODIFY"

        If DGV_scanvm.Rows.Count = 0 Then Exit Sub

        grp_wipfs_para.Visible = True

        txt_scanvm_id.Text = DGV_scanvm.SelectedRows(0).Cells("ID").Value
        txt_scanvm_id.ReadOnly = True
        txt_scanvm_lot.Text = DGV_scanvm.SelectedRows(0).Cells("Lot").Value
        txt_scanvm_scanjob.Text = DGV_scanvm.SelectedRows(0).Cells("SCANJOB").Value
        txt_scanvm_traystacking.Text = DGV_scanvm.SelectedRows(0).Cells("traystacking").Value
        txt_scanvm_yieldlimit.Text = DGV_scanvm.SelectedRows(0).Cells("yieldlimit").Value
        combo_scanvm_type.Text = DGV_scanvm.SelectedRows(0).Cells("Type").Value
        txt_scanvm_remark.Text = DGV_scanvm.SelectedRows(0).Cells("remark").Value


    End Sub

    Private Sub btn_wipfs_copy_Click(sender As Object, e As EventArgs) Handles btn_scanvm_copy.Click

        StepDefine_Mode = "COPY"

        If DGV_scanvm.Rows.Count = 0 Then Exit Sub

        grp_wipfs_para.Visible = True
        txt_scanvm_id.Text = ""

        txt_scanvm_lot.Text = DGV_scanvm.SelectedRows(0).Cells("Lot").Value
        combo_scanvm_type.Text = DGV_scanvm.SelectedRows(0).Cells("Type").Value
        txt_scanvm_scanjob.Text = DGV_scanvm.SelectedRows(0).Cells("SCANJOB").Value
        txt_scanvm_traystacking.Text = DGV_scanvm.SelectedRows(0).Cells("traystacking").Value
        txt_scanvm_yieldlimit.Text = DGV_scanvm.SelectedRows(0).Cells("yieldlimit").Value

        txt_scanvm_remark.Text = DGV_scanvm.SelectedRows(0).Cells("remark").Value

    End Sub

    Private Sub btn_wipfs_disable_Click(sender As Object, e As EventArgs) Handles btn_scanvm_disable.Click
        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_scanvm.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_SCANVM SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_scanvm.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_wipfs_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_wipfs_delete_Click(sender As Object, e As EventArgs) Handles btn_scanvm_delete.Click
        Dim mysql As String, s As Integer

        If DGV_scanvm.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_SCANVM WHERE ID ='" & DGV_scanvm.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_wipfs_Query_Click("", e)

        End If
    End Sub

    Private Sub combo_wipfs_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_scanvm_type.SelectedIndexChanged
        If combo_scanvm_type.Text = "SEN" Then
            txt_scanvm_lot.ReadOnly = False
            txt_scanvm_lot.Text = ""
        ElseIf combo_scanvm_type.Text = "ECN" Then
            txt_scanvm_lot.ReadOnly = True
            txt_scanvm_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_wipfs_exit_Click(sender As Object, e As EventArgs) Handles btn_scanvm_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_wipfs_confirm_Click(sender As Object, e As EventArgs) Handles btn_scanvm_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_scanvm_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If txt_scanvm_traystacking.Text = "" Or
                txt_scanvm_yieldlimit.Text = "" Or
                txt_scanvm_scanjob.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If Not IsNumeric(txt_scanvm_yieldlimit.Text) Then
            MsgBox("yieldlimit请输入数字", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_scanvm_type.Text = "ECN" Then
                mysql = "select * from Recipe_SCANVM where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_SCANVM")

                If mydataset.Tables("Recipe_SCANVM").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_scanvm_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_scanvm_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_SCANVM (ID,customer,InternalProduct,STAGE,Type,SCANJOB,traystacking,yieldlimit,ENABLE,Lot,remark,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & "SCANVM" & "','" & combo_scanvm_type.Text &
            "','" & txt_scanvm_scanjob.Text &
            "','" & txt_scanvm_traystacking.Text &
            "','" & txt_scanvm_yieldlimit.Text &
            "','TRUE','" & txt_scanvm_lot.Text & " ','" &
            txt_scanvm_remark.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_wipfs_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_SCANVM SET LOT= '" & txt_scanvm_lot.Text &
                    "',SCANJOB= '" & txt_scanvm_scanjob.Text &
                    "',traystacking= '" & txt_scanvm_traystacking.Text &
                    "',yieldlimit= '" & txt_scanvm_yieldlimit.Text &
                 "', ModifyTime='" & Now &
                 "',Modifier= '" & UserID &
                 "' WHERE ID= '" & txt_scanvm_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_wipfs_Query_Click("", e)

            End If

        End If

    End Sub

    'T/R Page Operation
    '''''''''''''''''''''''''''''''''''''''''
    Private Sub btn_TR_query_Click(sender As Object, e As EventArgs) Handles btn_TR_query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_TR_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_TR where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_TR where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_TR")

        If mydataset.Tables("Recipe_TR").Rows.Count = 0 Then
            DGV_TR.DataSource = Nothing

        Else

            DGV_TR.DataSource = mydataset.Tables("Recipe_TR")
            DGV_TR.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_TR_NEW_Click(sender As Object, e As EventArgs) Handles btn_TR_NEW.Click
        StepDefine_Mode = "NEW"
        grp_tr_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_TR_MODIFY_Click(sender As Object, e As EventArgs) Handles btn_TR_MODIFY.Click
        StepDefine_Mode = "MODIFY"

        If DGV_TR.Rows.Count = 0 Then Exit Sub

        grp_tr_para.Visible = True

        txt_tr_id.Text = DGV_TR.SelectedRows(0).Cells("ID").Value
        txt_tr_id.ReadOnly = True
        txt_tr_lot.Text = DGV_TR.SelectedRows(0).Cells("Lot").Value
        txt_tr_trjob.Text = DGV_TR.SelectedRows(0).Cells("TRJOB").Value
        txt_tr_yieldlimit.Text = DGV_TR.SelectedRows(0).Cells("yieldlimit").Value
        combo_TR_type.Text = DGV_TR.SelectedRows(0).Cells("Type").Value
        txt_tr_remark.Text = DGV_TR.SelectedRows(0).Cells("remark").Value
    End Sub

    Private Sub btn_TR_copy_Click(sender As Object, e As EventArgs) Handles btn_TR_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_TR.Rows.Count = 0 Then Exit Sub

        grp_tr_para.Visible = True
        txt_tr_id.Text = ""

        txt_tr_lot.Text = DGV_TR.SelectedRows(0).Cells("Lot").Value
        txt_tr_trjob.Text = DGV_TR.SelectedRows(0).Cells("TRJOB").Value
        txt_tr_yieldlimit.Text = DGV_TR.SelectedRows(0).Cells("yieldlimit").Value
        combo_TR_type.Text = DGV_TR.SelectedRows(0).Cells("Type").Value
        txt_tr_remark.Text = DGV_TR.SelectedRows(0).Cells("remark").Value
    End Sub

    Private Sub btn_TR_disable_Click(sender As Object, e As EventArgs) Handles btn_TR_disable.Click
        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_scanvm.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_TR SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_TR.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_TR_query_Click("", e)

        End If
    End Sub

    Private Sub btn_TR_delete_Click(sender As Object, e As EventArgs) Handles btn_TR_delete.Click
        Dim mysql As String, s As Integer

        If DGV_TR.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_TR WHERE ID ='" & DGV_TR.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_TR_query_Click("", e)

        End If
    End Sub

    Private Sub combo_TR_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_TR_type.SelectedIndexChanged
        If combo_TR_type.Text = "SEN" Then
            txt_tr_lot.ReadOnly = False
            txt_tr_lot.Text = ""
        ElseIf combo_TR_type.Text = "ECN" Then
            txt_tr_lot.ReadOnly = True
            txt_tr_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_tr_confirm_Click(sender As Object, e As EventArgs) Handles btn_tr_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_TR_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If txt_tr_trjob.Text = "" Or
                txt_tr_yieldlimit.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If Not IsNumeric(txt_tr_yieldlimit.Text) Then
            MsgBox("yieldlimit请输入数字!", vbOKOnly + vbExclamation)
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_TR_type.Text = "ECN" Then
                mysql = "select * from Recipe_TR where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_TR")

                If mydataset.Tables("Recipe_tr").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_TR_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_TR_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_TR (ID,customer,InternalProduct,STAGE,Type,TRJOB,yieldlimit,ENABLE,Lot,remark,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & "TR" & "','" & combo_TR_type.Text &
            "','" & txt_tr_trjob.Text &
            "','" & txt_tr_yieldlimit.Text &
            "','TRUE','" & txt_tr_lot.Text & " ','" &
            txt_tr_remark.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_wipfs_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_TR SET LOT= '" & txt_tr_lot.Text &
                    "',TRJOB= '" & txt_tr_trjob.Text &
                    "',yieldlimit= '" & txt_tr_yieldlimit.Text &
                 "', ModifyTime='" & Now &
                 "',Modifier= '" & UserID &
                 "' WHERE ID= '" & txt_tr_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_wipfs_Query_Click("", e)

            End If

        End If
    End Sub

    Private Sub btn_tr_exit_Click(sender As Object, e As EventArgs) Handles btn_tr_exit.Click
        Me.Close()
    End Sub






    ''''''''''''''''''''''''''''''''''''''''
    '''PACK Page Operation
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_pack_query_Click(sender As Object, e As EventArgs) Handles btn_pack_query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_pack_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_PACK where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_PACK where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_PACK")

        If mydataset.Tables("Recipe_PACK").Rows.Count = 0 Then
            DGV_PACK.DataSource = Nothing

        Else

            DGV_PACK.DataSource = mydataset.Tables("Recipe_PACK")
            DGV_PACK.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_pack_new_Click(sender As Object, e As EventArgs) Handles btn_pack_new.Click
        StepDefine_Mode = "NEW"
        grp_pack_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_pack_modify_Click(sender As Object, e As EventArgs) Handles btn_pack_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_PACK.Rows.Count = 0 Then Exit Sub

        grp_pack_para.Visible = True

        txt_pack_id.Text = DGV_PACK.SelectedRows(0).Cells("ID").Value
        txt_pack_id.ReadOnly = True
        txt_pack_lot.Text = DGV_PACK.SelectedRows(0).Cells("Lot").Value
        combo_pack_type.Text = DGV_PACK.SelectedRows(0).Cells("Type").Value
        txt_pack_remark.Text = DGV_PACK.SelectedRows(0).Cells("remark").Value
        txt_pack_packinfo.Text = DGV_PACK.SelectedRows(0).Cells("packinfo").Value
        txt_pack_traystacking.Text = DGV_PACK.SelectedRows(0).Cells("traystacking").Value
        txt_pack_msl.Text = DGV_PACK.SelectedRows(0).Cells("MSL").Value
        txt_pack_duetime.Text = DGV_PACK.SelectedRows(0).Cells("duetime").Value
        txt_pack_packingjob.Text = DGV_PACK.SelectedRows(0).Cells("packingjob").Value

    End Sub

    Private Sub btn_pack_copy_Click(sender As Object, e As EventArgs) Handles btn_pack_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_PACK.Rows.Count = 0 Then Exit Sub

        grp_pack_para.Visible = True
        txt_pack_id.Text = ""

        txt_pack_lot.Text = DGV_PACK.SelectedRows(0).Cells("Lot").Value
        combo_pack_type.Text = DGV_PACK.SelectedRows(0).Cells("Type").Value
        txt_pack_remark.Text = DGV_PACK.SelectedRows(0).Cells("remark").Value
        txt_pack_packinfo.Text = DGV_PACK.SelectedRows(0).Cells("packinfo").Value
        txt_pack_traystacking.Text = DGV_PACK.SelectedRows(0).Cells("traystacking").Value
        txt_pack_msl.Text = DGV_PACK.SelectedRows(0).Cells("MSL").Value
        txt_pack_duetime.Text = DGV_PACK.SelectedRows(0).Cells("duetime").Value
        txt_pack_packingjob.Text = DGV_PACK.SelectedRows(0).Cells("packingjob").Value

    End Sub

    Private Sub btn_pack_disable_Click(sender As Object, e As EventArgs) Handles btn_pack_disable.Click
        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_PACK.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_PACK SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_PACK.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_pack_query_Click("", e)

        End If





    End Sub

    Private Sub btn_pack_delete_Click(sender As Object, e As EventArgs) Handles btn_pack_delete.Click
        Dim mysql As String, s As Integer

        If DGV_PACK.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_PACK WHERE ID ='" & DGV_PACK.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_pack_query_Click("", e)

        End If





    End Sub

    Private Sub combo_pack_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_pack_type.SelectedIndexChanged
        If combo_pack_type.Text = "SEN" Then
            txt_pack_lot.ReadOnly = False
            txt_pack_lot.Text = ""
        ElseIf combo_pack_type.Text = "ECN" Then
            txt_pack_lot.ReadOnly = True
            txt_pack_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_pack_exit_Click(sender As Object, e As EventArgs) Handles btn_pack_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_pack_confirm_Click(sender As Object, e As EventArgs) Handles btn_pack_confirm.Click

        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_pack_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If txt_pack_packingjob.Text = "" Or
                txt_pack_traystacking.Text = "" Or
                txt_pack_msl.Text = "" Or
                txt_pack_duetime.Text = "" Or
                txt_pack_packinfo.Text = "" Then
            MsgBox("除注意事项/remark，其他项不得为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If IsNumeric(txt_pack_msl.Text) Then
            MsgBox("msl请输入数字!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_pack_type.Text = "ECN" Then
                mysql = "select * from Recipe_PACK where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_PACK")

                If mydataset.Tables("Recipe_PACK").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_pack_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_pack_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_PACK (ID,customer,InternalProduct,stage,Type,ENABLE,Lot,packingjob,traystacking,MSL,duetime,packinfo,remark,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & "PACK" & "','" & combo_pack_type.Text & "','TRUE','" & txt_pack_lot.Text &
            " ','" & txt_pack_packingjob.Text &
            " ','" & txt_pack_traystacking.Text &
            " ','" & txt_pack_msl.Text &
            " ','" & txt_pack_duetime.Text &
            " ','" & txt_pack_packinfo.Text &
            " ','" &
            txt_pack_remark.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_pack_query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_PACK SET LOT= '" & txt_pack_lot.Text &
                    "',packinfo= '" & txt_pack_packinfo.Text &
                    "',remark= '" & txt_pack_remark.Text &
                    "',packingjob= '" & txt_pack_packingjob.Text &
                    "',traystacking= '" & txt_pack_traystacking.Text &
                    "',MSL= '" & txt_pack_msl.Text &
                    "',duetime= '" & txt_pack_duetime.Text &
                 "', ModifyTime='" & Now &
                 "',Modifier= '" & UserID &
                 "' WHERE ID= '" & txt_pack_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_pack_query_Click("", e)

            End If

        End If

    End Sub







    ''''''''''''''''''''''''''''''''''''''''
    '''SHIP/OQC Page Operation
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_ship_query_Click(sender As Object, e As EventArgs) Handles btn_ship_query.Click
        Dim mysql As String
        Dim mydataset As New DataSet
        Select Case combo_ship_query.Text
            Case "ENABLE"
                If combo_SHIP_stagequery.Text = "ALL" Then
                    mysql = "select * from Recipe_SHIPOQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
                Else
                    mysql = "select * from Recipe_SHIPOQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND STAGE='" & combo_SHIP_stagequery.Text & "'"
                End If

            Case "ALL"
                If combo_SHIP_stagequery.Text = "ALL" Then
                    mysql = "select * from Recipe_SHIPOQC where InternalProduct='" & myProduct.InternalProduct & "'"
                Else
                    mysql = "select * from Recipe_SHIPOQC where InternalProduct='" & myProduct.InternalProduct & "'AND STAGE='" & combo_SHIP_stagequery.Text & "'"
                End If

        End Select

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_SHIPOQC")

        If mydataset.Tables("Recipe_SHIPOQC").Rows.Count = 0 Then
            DGV_SHIP.DataSource = Nothing

        Else

            DGV_SHIP.DataSource = mydataset.Tables("Recipe_SHIPOQC")
            DGV_SHIP.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_ship_new_Click(sender As Object, e As EventArgs) Handles btn_ship_new.Click
        StepDefine_Mode = "NEW"
        grp_ship_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_ship_modify_Click(sender As Object, e As EventArgs) Handles btn_ship_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_SHIP.Rows.Count = 0 Then Exit Sub

        grp_ship_para.Visible = True

        txt_ship_id.Text = DGV_SHIP.SelectedRows(0).Cells("ID").Value
        txt_ship_id.ReadOnly = True
        txt_ship_lot.Text = DGV_SHIP.SelectedRows(0).Cells("Lot").Value
        combo_ship_type.Text = DGV_SHIP.SelectedRows(0).Cells("Type").Value
        txt_ship_REMARK.Text = DGV_SHIP.SelectedRows(0).Cells("Remark").Value
        combo_ship_STAGE.Text = DGV_SHIP.SelectedRows(0).Cells("STAGE").Value

    End Sub

    Private Sub btn_ship_copy_Click(sender As Object, e As EventArgs) Handles btn_ship_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_SHIP.Rows.Count = 0 Then Exit Sub

        grp_ship_para.Visible = True
        txt_ship_id.Text = ""

        txt_ship_lot.Text = DGV_SHIP.SelectedRows(0).Cells("Lot").Value
        combo_ship_type.Text = DGV_SHIP.SelectedRows(0).Cells("Type").Value
        combo_ship_STAGE.Text = DGV_SHIP.SelectedRows(0).Cells("STAGE").Value
        txt_ship_REMARK.Text = DGV_SHIP.SelectedRows(0).Cells("Remark").Value
    End Sub

    Private Sub btn_ship_disable_Click(sender As Object, e As EventArgs) Handles btn_ship_disable.Click

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_SHIP.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_SHIPOQC SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_SHIP.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_ship_query_Click("", e)

        End If

    End Sub

    Private Sub btn_ship_delete_Click(sender As Object, e As EventArgs) Handles btn_ship_delete.Click

        Dim mysql As String, s As Integer

        If DGV_SHIP.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_SHIPOQC WHERE ID ='" & DGV_SHIP.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_ship_query_Click("", e)

        End If

    End Sub

    Private Sub combo_ship_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_ship_type.SelectedIndexChanged
        If combo_ship_type.Text = "SEN" Then
            txt_ship_lot.ReadOnly = False
            txt_ship_lot.Text = ""
        ElseIf combo_ship_type.Text = "ECN" Then
            txt_ship_lot.ReadOnly = True
            txt_ship_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_ship_exit_Click(sender As Object, e As EventArgs) Handles btn_ship_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_ship_confirm_Click(sender As Object, e As EventArgs) Handles btn_ship_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_ship_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If
        If combo_ship_STAGE.Text = "" Then
            MsgBox("STAGE未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_ship_type.Text = "ECN" Then
                mysql = "select * from Recipe_SHIPOQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_SHIPOQC")

                If mydataset.Tables("Recipe_SHIPOQC").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_ship_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_ship_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_SHIPOQC (ID,customer,InternalProduct,STAGE,Type,ENABLE,Lot,Remark,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_ship_STAGE.Text & "','" & combo_ship_type.Text & "','TRUE','" & txt_ship_lot.Text & " ','" &
            txt_ship_REMARK.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_ship_query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then
                mysql = "UPDATE Recipe_SHIPOQC SET LOT= '" & txt_ship_lot.Text & "',Remark= '" & txt_ship_REMARK.Text & "',STAGE= '" & combo_ship_STAGE.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_ship_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_ship_query_Click("", e)

            End If

        End If

    End Sub


    ''''''''''''''''''''''''''''''''''''''''
    ''mappic Operation
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_upload_Click(sender As Object, e As EventArgs)
        Dim sourcefile As String, destfile As String
        destfile = "\\10.10.31.99\cp_mes\RecipeSet\"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            sourcefile = OpenFileDialog1.FileName

            If InStr(sourcefile, " ") > 0 Then
                MsgBox("文件名包含空格!,请修改后上传", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            destfile += Format(Now(), "yyyyMMddHHmmss") + "_" + System.IO.Path.GetFileName(sourcefile)



            '文件复制
            FileCopy(sourcefile, destfile)

            'txt_attachpic.Text = destfile
            'txt_attachpic.Text = Replace(destfile, "10.10.31.99", "CPMES-SERVER")
            'MsgBox("上传成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If

    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs)
        Dim sourcefile As String, destfile As String

        'sourcefile = txt_attachpic.Text
        'sourcefile = Replace(txt_attachpic.Text, "CPMES-SERVER", "10.10.31.99")
        SaveFileDialog1.FileName = System.IO.Path.GetFileName(sourcefile)

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            destfile = SaveFileDialog1.FileName

            FileCopy(sourcefile, destfile)
            MsgBox("下载成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If
    End Sub



    Private Sub combo_cp_flowquery_DropDown(sender As Object, e As EventArgs)

        'combo_cp_flowquery.Items.Clear()
        'combo_cp_flowquery.Items.Add("ALL")
        'For i = 1 To 9
        '    combo_cp_flowquery.Items.Add("CP" & i)
        'Next

    End Sub



    Private Sub combo_cp_flow_DropDown(sender As Object, e As EventArgs) Handles combo_ft_STAGE.DropDown

        combo_ft_STAGE.Items.Clear()

        For i = 1 To 9
            combo_ft_STAGE.Items.Add("FT" & i)
        Next

    End Sub



    'Private Sub combo_cpdt_flowquery_DropDown(sender As Object, e As EventArgs) Handles combo_cpdt_flowquery.DropDown

    '    combo_cpdt_flowquery.Items.Clear()
    '    combo_cpdt_flowquery.Items.Add("ALL")
    '    For i = 1 To 9
    '        combo_cpdt_flowquery.Items.Add("CP" & i & "DT")
    '    Next


    'End Sub




    Private Sub combo_cpdt_flow_DropDown(sender As Object, e As EventArgs) Handles combo_QC_Stage.DropDown

        combo_QC_Stage.Items.Clear()

        For i = 1 To 9
            combo_QC_Stage.Items.Add("QC" & i)
        Next

    End Sub

    Private Sub combo_cp_tester_DropDown(sender As Object, e As EventArgs)

        Dim grparray() As String
        grparray = GetTesterGrp()

        'combo_cp_tester.Items.Clear()
        'For i = 0 To UBound(grparray) - 1
        '    combo_cp_tester.Items.Add(grparray(i))
        'Next

    End Sub

    Private Sub Combo_ftn_auto1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_ft_auto1.SelectedIndexChanged
        If ChkB1_FT.Checked Then
            ChkB1_FT.Checked = False
        End If


    End Sub

    Private Sub Combo_ftn_auto2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_ft_auto2.SelectedIndexChanged
        If ChkB2_FT.Checked Then
            ChkB2_FT.Checked = False
        End If
    End Sub

    Private Sub Combo_ftn_auto3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_ft_auto3.SelectedIndexChanged
        If ChkB3_FT.Checked Then
            ChkB3_FT.Checked = False
        End If
    End Sub

    Private Sub Combo_ftn_FIX1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_ft_FIX1.SelectedIndexChanged
        If ChkB4_FT.Checked Then
            ChkB4_FT.Checked = False
        End If
    End Sub

    Private Sub Combo_ftn_FIX2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_ft_FIX2.SelectedIndexChanged
        If ChkB5_FT.Checked Then
            ChkB5_FT.Checked = False
        End If
    End Sub

    Private Sub Combo_ftn_FIX3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_ft_FIX3.SelectedIndexChanged
        If ChkB6_FT.Checked Then
            ChkB6_FT.Checked = False
        End If
    End Sub

    Private Sub ChkB1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB1_FT.CheckedChanged
        If Combo_ft_auto1.Text <> "" Then
            Combo_ft_auto1.Text = Combo_ft_auto1.Text + "+E"

        End If
        If Combo_ft_auto1.Text.Length > 6 Then
            str = Combo_ft_auto1.Text
            Combo_ft_auto1.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB2_FT.CheckedChanged
        If Combo_ft_auto2.Text <> "" Then
            Combo_ft_auto2.Text = Combo_ft_auto2.Text + "+E"
        End If
        If Combo_ft_auto2.Text.Length > 6 Then
            str = Combo_ft_auto2.Text
            Combo_ft_auto2.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB3_FT.CheckedChanged
        If Combo_ft_auto3.Text <> "" Then
            Combo_ft_auto3.Text = Combo_ft_auto3.Text + "+E"
        End If
        If Combo_ft_auto3.Text.Length > 6 Then
            str = Combo_ft_auto3.Text
            Combo_ft_auto3.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB4_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB4_FT.CheckedChanged
        If Combo_ft_FIX1.Text <> "" Then
            Combo_ft_FIX1.Text = Combo_ft_FIX1.Text + "+E"
        End If
        If Combo_ft_FIX1.Text.Length > 6 Then
            str = Combo_ft_FIX1.Text
            Combo_ft_FIX1.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB5_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB5_FT.CheckedChanged
        If Combo_ft_FIX2.Text <> "" Then
            Combo_ft_FIX2.Text = Combo_ft_FIX2.Text + "+E"
        End If
        If Combo_ft_FIX2.Text.Length > 6 Then
            str = Combo_ft_FIX2.Text
            Combo_ft_FIX2.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB6_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB6_FT.CheckedChanged
        If Combo_ft_FIX3.Text <> "" Then
            Combo_ft_FIX3.Text = Combo_ft_FIX3.Text + "+E"
        End If
        If Combo_ft_FIX3.Text.Length > 6 Then
            str = Combo_ft_FIX3.Text
            Combo_ft_FIX3.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub Combo_QC_AUTO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_QC_AUTO1.SelectedIndexChanged
        If ChkB1_QC.Checked Then
            ChkB1_QC.Checked = False
        End If
    End Sub

    Private Sub Combo_QC_AUTO2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_QC_AUTO2.SelectedIndexChanged
        If ChkB2_QC.Checked Then
            ChkB2_QC.Checked = False
        End If
    End Sub

    Private Sub Combo_QC_AUTO3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_QC_AUTO3.SelectedIndexChanged
        If ChkB3_QC.Checked Then
            ChkB3_QC.Checked = False
        End If
    End Sub

    Private Sub Combo_QC_FIX1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_QC_FIX1.SelectedIndexChanged
        If ChkB4_QC.Checked Then
            ChkB4_QC.Checked = False
        End If
    End Sub

    Private Sub Combo_QC_FIX2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_QC_FIX2.SelectedIndexChanged
        If ChkB5_QC.Checked Then
            ChkB5_QC.Checked = False
        End If
    End Sub

    Private Sub Combo_QC_FIX3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_QC_FIX3.SelectedIndexChanged
        If ChkB6_QC.Checked Then
            ChkB6_QC.Checked = False
        End If
    End Sub

    Private Sub ChkB1_QC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB1_QC.CheckedChanged
        If Combo_QC_AUTO1.Text <> "" Then
            Combo_QC_AUTO1.Text = Combo_QC_AUTO1.Text + "+E"
        End If
        If Combo_QC_AUTO1.Text.Length > 6 Then
            str = Combo_QC_AUTO1.Text
            Combo_QC_AUTO1.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB2_QC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB2_QC.CheckedChanged
        If Combo_QC_AUTO2.Text <> "" Then
            Combo_QC_AUTO2.Text = Combo_QC_AUTO2.Text + "+E"
        End If
        If Combo_QC_AUTO2.Text.Length > 6 Then
            str = Combo_QC_AUTO2.Text
            Combo_QC_AUTO2.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB3_QC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB3_QC.CheckedChanged
        If Combo_QC_AUTO3.Text <> "" Then
            Combo_QC_AUTO3.Text = Combo_QC_AUTO3.Text + "+E"
        End If
        If Combo_QC_AUTO3.Text.Length > 6 Then
            str = Combo_QC_AUTO3.Text
            Combo_QC_AUTO3.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB4_QC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB4_QC.CheckedChanged
        If Combo_QC_FIX1.Text <> "" Then
            Combo_QC_FIX1.Text = Combo_QC_FIX1.Text + "+E"
        End If
        If Combo_QC_FIX1.Text.Length > 6 Then
            str = Combo_QC_FIX1.Text
            Combo_QC_FIX1.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB5_QC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB5_QC.CheckedChanged
        If Combo_QC_FIX2.Text <> "" Then
            Combo_QC_FIX2.Text = Combo_QC_FIX2.Text + "+E"
        End If
        If Combo_QC_FIX2.Text.Length > 6 Then
            str = Combo_QC_FIX2.Text
            Combo_QC_FIX2.Text = str.Substring(0, 4)
        End If
    End Sub

    Private Sub ChkB6_QC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkB6_QC.CheckedChanged
        If Combo_QC_FIX3.Text <> "" Then
            Combo_QC_FIX3.Text = Combo_QC_FIX3.Text + "+E"
        End If
        If Combo_QC_FIX3.Text.Length > 6 Then
            str = Combo_QC_FIX3.Text
            Combo_QC_FIX3.Text = str.Substring(0, 4)
        End If
    End Sub

    ''Private Sub txt_bake_baketime_TextChanged(sender As Object, e As EventArgs) Handles txt_bake_baketime.TextChanged
    ''    If Not IsNumeric(txt_bake_baketime.Text) Then

    ''        MsgBox("请输入数字!", vbOKOnly)
    ''        'txt_bake_baketime.Text = ""
    ''    End If
    ''End Sub
End Class

