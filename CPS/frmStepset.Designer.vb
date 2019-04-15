<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStepset
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TR = New System.Windows.Forms.TabPage()
        Me.grp_tr_para = New System.Windows.Forms.Panel()
        Me.txt_tr_yieldlimit = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.txt_tr_trjob = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.btn_tr_exit = New System.Windows.Forms.Button()
        Me.btn_tr_confirm = New System.Windows.Forms.Button()
        Me.txt_tr_lot = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.combo_TR_type = New System.Windows.Forms.ComboBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.txt_tr_id = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.txt_tr_remark = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.combo_TR_query = New System.Windows.Forms.ComboBox()
        Me.btn_TR_query = New System.Windows.Forms.Button()
        Me.btn_TR_delete = New System.Windows.Forms.Button()
        Me.btn_TR_disable = New System.Windows.Forms.Button()
        Me.btn_TR_copy = New System.Windows.Forms.Button()
        Me.btn_TR_MODIFY = New System.Windows.Forms.Button()
        Me.btn_TR_NEW = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_TR = New System.Windows.Forms.DataGridView()
        Me.SHIPOQC = New System.Windows.Forms.TabPage()
        Me.grp_ship_para = New System.Windows.Forms.GroupBox()
        Me.combo_ship_STAGE = New System.Windows.Forms.ComboBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.btn_ship_exit = New System.Windows.Forms.Button()
        Me.btn_ship_confirm = New System.Windows.Forms.Button()
        Me.txt_ship_lot = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.combo_ship_type = New System.Windows.Forms.ComboBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txt_ship_id = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txt_ship_REMARK = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.combo_SHIP_stagequery = New System.Windows.Forms.ComboBox()
        Me.combo_ship_query = New System.Windows.Forms.ComboBox()
        Me.btn_ship_query = New System.Windows.Forms.Button()
        Me.btn_ship_delete = New System.Windows.Forms.Button()
        Me.btn_ship_disable = New System.Windows.Forms.Button()
        Me.btn_ship_copy = New System.Windows.Forms.Button()
        Me.btn_ship_modify = New System.Windows.Forms.Button()
        Me.btn_ship_new = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.DGV_SHIP = New System.Windows.Forms.DataGridView()
        Me.PACK = New System.Windows.Forms.TabPage()
        Me.grp_pack_para = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txt_pack_packinfo = New System.Windows.Forms.TextBox()
        Me.txt_pack_duetime = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.txt_pack_msl = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txt_pack_traystacking = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txt_pack_packingjob = New System.Windows.Forms.TextBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.btn_pack_exit = New System.Windows.Forms.Button()
        Me.btn_pack_confirm = New System.Windows.Forms.Button()
        Me.txt_pack_lot = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.combo_pack_type = New System.Windows.Forms.ComboBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txt_pack_id = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txt_pack_remark = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.combo_pack_query = New System.Windows.Forms.ComboBox()
        Me.btn_pack_query = New System.Windows.Forms.Button()
        Me.btn_pack_delete = New System.Windows.Forms.Button()
        Me.btn_pack_disable = New System.Windows.Forms.Button()
        Me.btn_pack_copy = New System.Windows.Forms.Button()
        Me.btn_pack_modify = New System.Windows.Forms.Button()
        Me.btn_pack_new = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.DGV_PACK = New System.Windows.Forms.DataGridView()
        Me.FQC = New System.Windows.Forms.TabPage()
        Me.grp_FQC_para = New System.Windows.Forms.GroupBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_FQC_traystacking = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_FQC_stage = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txt_FQC_Remark = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn_FQC_exit = New System.Windows.Forms.Button()
        Me.btn_FQC_confirm = New System.Windows.Forms.Button()
        Me.txt_FQC_lot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combo_FQC_type = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_FQC_ID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_FQC_Attention = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_FQC_SampleSize = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.combo_FQC_query = New System.Windows.Forms.ComboBox()
        Me.btn_FQC_query = New System.Windows.Forms.Button()
        Me.btn_FQC_delete = New System.Windows.Forms.Button()
        Me.btn_FQC_disable = New System.Windows.Forms.Button()
        Me.btn_FQC_copy = New System.Windows.Forms.Button()
        Me.btn_FQC_modify = New System.Windows.Forms.Button()
        Me.btn_FQC_new = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DGV_FQC = New System.Windows.Forms.DataGridView()
        Me.SCANVM = New System.Windows.Forms.TabPage()
        Me.grp_wipfs_para = New System.Windows.Forms.GroupBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_scanvm_yieldlimit = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txt_scanvm_traystacking = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txt_scanvm_scanjob = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_scanvm_exit = New System.Windows.Forms.Button()
        Me.btn_scanvm_confirm = New System.Windows.Forms.Button()
        Me.txt_scanvm_lot = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.combo_scanvm_type = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_scanvm_id = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_scanvm_remark = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.combo_scanvm_query = New System.Windows.Forms.ComboBox()
        Me.btn_scanvm_Query = New System.Windows.Forms.Button()
        Me.btn_scanvm_delete = New System.Windows.Forms.Button()
        Me.btn_scanvm_disable = New System.Windows.Forms.Button()
        Me.btn_scanvm_copy = New System.Windows.Forms.Button()
        Me.btn_scanvm_modify = New System.Windows.Forms.Button()
        Me.btn_scanvm_new = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.DGV_scanvm = New System.Windows.Forms.DataGridView()
        Me.QCn = New System.Windows.Forms.TabPage()
        Me.grp_cpdt_para = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_QC_samplingsize = New System.Windows.Forms.TextBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.txt_QC_testtime = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Combo_QC_FIX3 = New System.Windows.Forms.ComboBox()
        Me.Combo_QC_FIX2 = New System.Windows.Forms.ComboBox()
        Me.Combo_QC_FIX1 = New System.Windows.Forms.ComboBox()
        Me.Combo_QC_AUTO3 = New System.Windows.Forms.ComboBox()
        Me.Combo_QC_AUTO2 = New System.Windows.Forms.ComboBox()
        Me.Combo_QC_AUTO1 = New System.Windows.Forms.ComboBox()
        Me.ChkB6_QC = New System.Windows.Forms.CheckBox()
        Me.ChkB5_QC = New System.Windows.Forms.CheckBox()
        Me.ChkB4_QC = New System.Windows.Forms.CheckBox()
        Me.ChkB3_QC = New System.Windows.Forms.CheckBox()
        Me.ChkB2_QC = New System.Windows.Forms.CheckBox()
        Me.ChkB1_QC = New System.Windows.Forms.CheckBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txt_QC_loadboard = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.txt_QC_soaktime = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txt_QC_temp = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.txt_QC_swrev = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.txt_QC_os = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.txt_QC_testmode = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txt_QC_setupfile = New System.Windows.Forms.TextBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.txt_QC_Handler = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.txt_QC_TestFlatform = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.txt_QC_Remark = New System.Windows.Forms.TextBox()
        Me.combo_QC_Stage = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txt_QC_exit = New System.Windows.Forms.Button()
        Me.txt_QC_confirm = New System.Windows.Forms.Button()
        Me.txt_QC_lot = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.combo_QC_type = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txt_QC_id = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_QC_Attention = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.combo_QC_stagequery = New System.Windows.Forms.ComboBox()
        Me.combo_QC_enable = New System.Windows.Forms.ComboBox()
        Me.btn_QC_Query = New System.Windows.Forms.Button()
        Me.btn_QC_delete = New System.Windows.Forms.Button()
        Me.btn_QC_disable = New System.Windows.Forms.Button()
        Me.btn_QC_copy = New System.Windows.Forms.Button()
        Me.btn_QC_modify = New System.Windows.Forms.Button()
        Me.btn_QC_new = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.DGV_QC = New System.Windows.Forms.DataGridView()
        Me.BAKE = New System.Windows.Forms.TabPage()
        Me.grp_bake_para = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_bake_GasFlow = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txt_bake_tempgruve = New System.Windows.Forms.TextBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.txt_bake_bakingtime = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt_bake_baketime = New System.Windows.Forms.TextBox()
        Me.combo_bake_recipe = New System.Windows.Forms.ComboBox()
        Me.btn_bake_exit = New System.Windows.Forms.Button()
        Me.btn_bake_confirm = New System.Windows.Forms.Button()
        Me.txt_BAKE_lot = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.combo_BAKE_type = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_BAKE_id = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txt_bake_remark = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_bake_temp = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.combo_BAKE_query = New System.Windows.Forms.ComboBox()
        Me.btn_BAKE_Query = New System.Windows.Forms.Button()
        Me.btn_BAKE_delete = New System.Windows.Forms.Button()
        Me.btn_BAKE_disable = New System.Windows.Forms.Button()
        Me.btn_BAKE_copy = New System.Windows.Forms.Button()
        Me.btn_BAKE_modify = New System.Windows.Forms.Button()
        Me.btn_BAKE_new = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGV_BAKE = New System.Windows.Forms.DataGridView()
        Me.FTn = New System.Windows.Forms.TabPage()
        Me.grp_CP_para = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_FT_TestTime = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Combo_ft_FIX3 = New System.Windows.Forms.ComboBox()
        Me.Combo_ft_FIX2 = New System.Windows.Forms.ComboBox()
        Me.Combo_ft_FIX1 = New System.Windows.Forms.ComboBox()
        Me.Combo_ft_auto3 = New System.Windows.Forms.ComboBox()
        Me.Combo_ft_auto2 = New System.Windows.Forms.ComboBox()
        Me.Combo_ft_auto1 = New System.Windows.Forms.ComboBox()
        Me.ChkB6_FT = New System.Windows.Forms.CheckBox()
        Me.ChkB5_FT = New System.Windows.Forms.CheckBox()
        Me.ChkB4_FT = New System.Windows.Forms.CheckBox()
        Me.ChkB3_FT = New System.Windows.Forms.CheckBox()
        Me.ChkB2_FT = New System.Windows.Forms.CheckBox()
        Me.ChkB1_FT = New System.Windows.Forms.CheckBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_FTn_remark = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_FTn_attention = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_FT_OtherSBL = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_FT_HighYieldLimit = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_FT_OsLimit = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_FT_YieldLimit = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_FT_LoadBoard = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_FT_SOAKTIME = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_FT_TestTemp = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_FT_SWRev = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_FT_Os = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_FT_TestMode = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_FT_SetupFile = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_FT_Handler = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_FT_TestFlatform = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.combo_ft_STAGE = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_cp_exit = New System.Windows.Forms.Button()
        Me.btn_cp_confirm = New System.Windows.Forms.Button()
        Me.txt_ftn_lot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_ft_type = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ft_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.combo_ft_stagequery = New System.Windows.Forms.ComboBox()
        Me.combo_ft_enable = New System.Windows.Forms.ComboBox()
        Me.btn_ft_Query = New System.Windows.Forms.Button()
        Me.btn_ft_delete = New System.Windows.Forms.Button()
        Me.btn_ft_disable = New System.Windows.Forms.Button()
        Me.btn_ft_copy = New System.Windows.Forms.Button()
        Me.btn_ft_modify = New System.Windows.Forms.Button()
        Me.btn_ft_new = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGV_FT = New System.Windows.Forms.DataGridView()
        Me.IQC = New System.Windows.Forms.TabPage()
        Me.grp_IQC_para = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_IQC_cancel = New System.Windows.Forms.Button()
        Me.btn_IQC_confirm = New System.Windows.Forms.Button()
        Me.txt_IQC_lot = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.combo_IQC_type = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_IQC_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_IQC_Remark = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_IQC_SampleSize = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_IQC_query = New System.Windows.Forms.ComboBox()
        Me.btn_IQC_Query = New System.Windows.Forms.Button()
        Me.btn_IQC_delete = New System.Windows.Forms.Button()
        Me.btn_IQC_disable = New System.Windows.Forms.Button()
        Me.btn_iqc_copy = New System.Windows.Forms.Button()
        Me.btn_IQC_modify = New System.Windows.Forms.Button()
        Me.btn_IQC_new = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_IQC = New System.Windows.Forms.DataGridView()
        Me.Tabcontrol = New System.Windows.Forms.TabControl()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TR.SuspendLayout()
        Me.grp_tr_para.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_TR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SHIPOQC.SuspendLayout()
        Me.grp_ship_para.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.DGV_SHIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PACK.SuspendLayout()
        Me.grp_pack_para.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.DGV_PACK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FQC.SuspendLayout()
        Me.grp_FQC_para.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DGV_FQC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCANVM.SuspendLayout()
        Me.grp_wipfs_para.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DGV_scanvm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QCn.SuspendLayout()
        Me.grp_cpdt_para.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DGV_QC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BAKE.SuspendLayout()
        Me.grp_bake_para.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGV_BAKE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FTn.SuspendLayout()
        Me.grp_CP_para.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_FT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IQC.SuspendLayout()
        Me.grp_IQC_para.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_IQC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabcontrol.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(3, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1069, 205)
        Me.DataGridView1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(336, 23)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 37)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "NEW"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(486, 23)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 37)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "MODIFY"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(635, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 37)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "COPY"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(780, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 37)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "DISABLE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(932, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(214, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "QUERY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.ComboBox1.Location = New System.Drawing.Point(21, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(62, 20)
        Me.ComboBox1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 610)
        Me.Panel1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(69, -67)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(477, 572)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(656, 16)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(502, 572)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = ""
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(119, 548)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(259, 188)
        Me.RichTextBox3.TabIndex = 2
        Me.RichTextBox3.Text = ""
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(602, 840)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 49)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TR
        '
        Me.TR.Controls.Add(Me.grp_tr_para)
        Me.TR.Controls.Add(Me.GroupBox18)
        Me.TR.Controls.Add(Me.GroupBox2)
        Me.TR.Location = New System.Drawing.Point(4, 24)
        Me.TR.Name = "TR"
        Me.TR.Size = New System.Drawing.Size(1215, 932)
        Me.TR.TabIndex = 8
        Me.TR.Text = "T/R"
        Me.TR.UseVisualStyleBackColor = True
        '
        'grp_tr_para
        '
        Me.grp_tr_para.Controls.Add(Me.txt_tr_yieldlimit)
        Me.grp_tr_para.Controls.Add(Me.Label100)
        Me.grp_tr_para.Controls.Add(Me.txt_tr_trjob)
        Me.grp_tr_para.Controls.Add(Me.Label102)
        Me.grp_tr_para.Controls.Add(Me.btn_tr_exit)
        Me.grp_tr_para.Controls.Add(Me.btn_tr_confirm)
        Me.grp_tr_para.Controls.Add(Me.txt_tr_lot)
        Me.grp_tr_para.Controls.Add(Me.Label103)
        Me.grp_tr_para.Controls.Add(Me.combo_TR_type)
        Me.grp_tr_para.Controls.Add(Me.Label104)
        Me.grp_tr_para.Controls.Add(Me.txt_tr_id)
        Me.grp_tr_para.Controls.Add(Me.Label105)
        Me.grp_tr_para.Controls.Add(Me.txt_tr_remark)
        Me.grp_tr_para.Controls.Add(Me.Label106)
        Me.grp_tr_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_tr_para.Location = New System.Drawing.Point(0, 270)
        Me.grp_tr_para.Name = "grp_tr_para"
        Me.grp_tr_para.Size = New System.Drawing.Size(1215, 662)
        Me.grp_tr_para.TabIndex = 31
        Me.grp_tr_para.Visible = False
        '
        'txt_tr_yieldlimit
        '
        Me.txt_tr_yieldlimit.Location = New System.Drawing.Point(434, 65)
        Me.txt_tr_yieldlimit.Name = "txt_tr_yieldlimit"
        Me.txt_tr_yieldlimit.Size = New System.Drawing.Size(162, 21)
        Me.txt_tr_yieldlimit.TabIndex = 204
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(343, 71)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(77, 12)
        Me.Label100.TabIndex = 203
        Me.Label100.Text = "Yield Limit:"
        '
        'txt_tr_trjob
        '
        Me.txt_tr_trjob.Location = New System.Drawing.Point(434, 23)
        Me.txt_tr_trjob.Name = "txt_tr_trjob"
        Me.txt_tr_trjob.Size = New System.Drawing.Size(162, 21)
        Me.txt_tr_trjob.TabIndex = 200
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(343, 29)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(53, 12)
        Me.Label102.TabIndex = 199
        Me.Label102.Text = "T/R Job:"
        '
        'btn_tr_exit
        '
        Me.btn_tr_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_tr_exit.Location = New System.Drawing.Point(515, 393)
        Me.btn_tr_exit.Name = "btn_tr_exit"
        Me.btn_tr_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_tr_exit.TabIndex = 40
        Me.btn_tr_exit.UseVisualStyleBackColor = True
        '
        'btn_tr_confirm
        '
        Me.btn_tr_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_tr_confirm.Location = New System.Drawing.Point(139, 393)
        Me.btn_tr_confirm.Name = "btn_tr_confirm"
        Me.btn_tr_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_tr_confirm.TabIndex = 39
        Me.btn_tr_confirm.UseVisualStyleBackColor = True
        '
        'txt_tr_lot
        '
        Me.txt_tr_lot.Location = New System.Drawing.Point(139, 101)
        Me.txt_tr_lot.Multiline = True
        Me.txt_tr_lot.Name = "txt_tr_lot"
        Me.txt_tr_lot.ReadOnly = True
        Me.txt_tr_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_tr_lot.Size = New System.Drawing.Size(162, 54)
        Me.txt_tr_lot.TabIndex = 38
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Location = New System.Drawing.Point(88, 101)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(35, 12)
        Me.Label103.TabIndex = 37
        Me.Label103.Text = "LOT :"
        '
        'combo_TR_type
        '
        Me.combo_TR_type.FormattingEnabled = True
        Me.combo_TR_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_TR_type.Location = New System.Drawing.Point(139, 59)
        Me.combo_TR_type.Name = "combo_TR_type"
        Me.combo_TR_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_TR_type.TabIndex = 36
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(46, 59)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(77, 12)
        Me.Label104.TabIndex = 35
        Me.Label104.Text = "Recipe Type:"
        '
        'txt_tr_id
        '
        Me.txt_tr_id.ForeColor = System.Drawing.Color.Red
        Me.txt_tr_id.Location = New System.Drawing.Point(139, 27)
        Me.txt_tr_id.Name = "txt_tr_id"
        Me.txt_tr_id.ReadOnly = True
        Me.txt_tr_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_tr_id.TabIndex = 34
        Me.txt_tr_id.Text = "R"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Location = New System.Drawing.Point(58, 32)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(65, 12)
        Me.Label105.TabIndex = 33
        Me.Label105.Text = "Recipe ID:"
        '
        'txt_tr_remark
        '
        Me.txt_tr_remark.Location = New System.Drawing.Point(48, 238)
        Me.txt_tr_remark.Multiline = True
        Me.txt_tr_remark.Name = "txt_tr_remark"
        Me.txt_tr_remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_tr_remark.Size = New System.Drawing.Size(716, 82)
        Me.txt_tr_remark.TabIndex = 32
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Location = New System.Drawing.Point(46, 213)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(65, 12)
        Me.Label106.TabIndex = 31
        Me.Label106.Text = "1. Remark:"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.combo_TR_query)
        Me.GroupBox18.Controls.Add(Me.btn_TR_query)
        Me.GroupBox18.Controls.Add(Me.btn_TR_delete)
        Me.GroupBox18.Controls.Add(Me.btn_TR_disable)
        Me.GroupBox18.Controls.Add(Me.btn_TR_copy)
        Me.GroupBox18.Controls.Add(Me.btn_TR_MODIFY)
        Me.GroupBox18.Controls.Add(Me.btn_TR_NEW)
        Me.GroupBox18.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox18.Location = New System.Drawing.Point(0, 200)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(1215, 70)
        Me.GroupBox18.TabIndex = 21
        Me.GroupBox18.TabStop = False
        '
        'combo_TR_query
        '
        Me.combo_TR_query.FormattingEnabled = True
        Me.combo_TR_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_TR_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_TR_query.Name = "combo_TR_query"
        Me.combo_TR_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_TR_query.TabIndex = 6
        Me.combo_TR_query.Text = "ENABLE"
        '
        'btn_TR_query
        '
        Me.btn_TR_query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_TR_query.ForeColor = System.Drawing.Color.Black
        Me.btn_TR_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_TR_query.Location = New System.Drawing.Point(330, 20)
        Me.btn_TR_query.Name = "btn_TR_query"
        Me.btn_TR_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_TR_query.TabIndex = 5
        Me.btn_TR_query.UseVisualStyleBackColor = False
        '
        'btn_TR_delete
        '
        Me.btn_TR_delete.BackColor = System.Drawing.Color.Red
        Me.btn_TR_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_TR_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_TR_delete.Name = "btn_TR_delete"
        Me.btn_TR_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_TR_delete.TabIndex = 4
        Me.btn_TR_delete.UseVisualStyleBackColor = False
        Me.btn_TR_delete.Visible = False
        '
        'btn_TR_disable
        '
        Me.btn_TR_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_TR_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_TR_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_TR_disable.Name = "btn_TR_disable"
        Me.btn_TR_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_TR_disable.TabIndex = 3
        Me.btn_TR_disable.UseVisualStyleBackColor = False
        '
        'btn_TR_copy
        '
        Me.btn_TR_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_TR_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_TR_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_TR_copy.Name = "btn_TR_copy"
        Me.btn_TR_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_TR_copy.TabIndex = 2
        Me.btn_TR_copy.UseVisualStyleBackColor = False
        '
        'btn_TR_MODIFY
        '
        Me.btn_TR_MODIFY.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_TR_MODIFY.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_TR_MODIFY.Location = New System.Drawing.Point(570, 20)
        Me.btn_TR_MODIFY.Name = "btn_TR_MODIFY"
        Me.btn_TR_MODIFY.Size = New System.Drawing.Size(90, 32)
        Me.btn_TR_MODIFY.TabIndex = 1
        Me.btn_TR_MODIFY.UseVisualStyleBackColor = False
        '
        'btn_TR_NEW
        '
        Me.btn_TR_NEW.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_TR_NEW.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_TR_NEW.Location = New System.Drawing.Point(450, 20)
        Me.btn_TR_NEW.Name = "btn_TR_NEW"
        Me.btn_TR_NEW.Size = New System.Drawing.Size(90, 32)
        Me.btn_TR_NEW.TabIndex = 0
        Me.btn_TR_NEW.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_TR)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1215, 200)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'DGV_TR
        '
        Me.DGV_TR.AllowUserToAddRows = False
        Me.DGV_TR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_TR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_TR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_TR.Location = New System.Drawing.Point(3, 17)
        Me.DGV_TR.Name = "DGV_TR"
        Me.DGV_TR.ReadOnly = True
        Me.DGV_TR.RowHeadersVisible = False
        Me.DGV_TR.RowTemplate.Height = 23
        Me.DGV_TR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_TR.Size = New System.Drawing.Size(1209, 180)
        Me.DGV_TR.TabIndex = 0
        '
        'SHIPOQC
        '
        Me.SHIPOQC.Controls.Add(Me.grp_ship_para)
        Me.SHIPOQC.Controls.Add(Me.GroupBox17)
        Me.SHIPOQC.Controls.Add(Me.GroupBox16)
        Me.SHIPOQC.Location = New System.Drawing.Point(4, 24)
        Me.SHIPOQC.Name = "SHIPOQC"
        Me.SHIPOQC.Padding = New System.Windows.Forms.Padding(3)
        Me.SHIPOQC.Size = New System.Drawing.Size(1215, 932)
        Me.SHIPOQC.TabIndex = 7
        Me.SHIPOQC.Text = "SHIP/OQC"
        Me.SHIPOQC.UseVisualStyleBackColor = True
        '
        'grp_ship_para
        '
        Me.grp_ship_para.Controls.Add(Me.combo_ship_STAGE)
        Me.grp_ship_para.Controls.Add(Me.Label101)
        Me.grp_ship_para.Controls.Add(Me.btn_ship_exit)
        Me.grp_ship_para.Controls.Add(Me.btn_ship_confirm)
        Me.grp_ship_para.Controls.Add(Me.txt_ship_lot)
        Me.grp_ship_para.Controls.Add(Me.Label61)
        Me.grp_ship_para.Controls.Add(Me.combo_ship_type)
        Me.grp_ship_para.Controls.Add(Me.Label63)
        Me.grp_ship_para.Controls.Add(Me.txt_ship_id)
        Me.grp_ship_para.Controls.Add(Me.Label64)
        Me.grp_ship_para.Controls.Add(Me.txt_ship_REMARK)
        Me.grp_ship_para.Controls.Add(Me.Label65)
        Me.grp_ship_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_ship_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_ship_para.Name = "grp_ship_para"
        Me.grp_ship_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_ship_para.TabIndex = 27
        Me.grp_ship_para.TabStop = False
        Me.grp_ship_para.Text = "Parameters"
        Me.grp_ship_para.Visible = False
        '
        'combo_ship_STAGE
        '
        Me.combo_ship_STAGE.FormattingEnabled = True
        Me.combo_ship_STAGE.Location = New System.Drawing.Point(129, 90)
        Me.combo_ship_STAGE.Name = "combo_ship_STAGE"
        Me.combo_ship_STAGE.Size = New System.Drawing.Size(162, 20)
        Me.combo_ship_STAGE.TabIndex = 145
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(44, 90)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(41, 12)
        Me.Label101.TabIndex = 144
        Me.Label101.Text = "stage:"
        '
        'btn_ship_exit
        '
        Me.btn_ship_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_ship_exit.Location = New System.Drawing.Point(480, 321)
        Me.btn_ship_exit.Name = "btn_ship_exit"
        Me.btn_ship_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_exit.TabIndex = 28
        Me.btn_ship_exit.UseVisualStyleBackColor = True
        '
        'btn_ship_confirm
        '
        Me.btn_ship_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_ship_confirm.Location = New System.Drawing.Point(104, 321)
        Me.btn_ship_confirm.Name = "btn_ship_confirm"
        Me.btn_ship_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_confirm.TabIndex = 27
        Me.btn_ship_confirm.UseVisualStyleBackColor = True
        '
        'txt_ship_lot
        '
        Me.txt_ship_lot.Location = New System.Drawing.Point(413, 27)
        Me.txt_ship_lot.Multiline = True
        Me.txt_ship_lot.Name = "txt_ship_lot"
        Me.txt_ship_lot.ReadOnly = True
        Me.txt_ship_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_ship_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_ship_lot.TabIndex = 26
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(369, 32)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(35, 12)
        Me.Label61.TabIndex = 25
        Me.Label61.Text = "LOT :"
        '
        'combo_ship_type
        '
        Me.combo_ship_type.FormattingEnabled = True
        Me.combo_ship_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_ship_type.Location = New System.Drawing.Point(129, 61)
        Me.combo_ship_type.Name = "combo_ship_type"
        Me.combo_ship_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_ship_type.TabIndex = 24
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(36, 61)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(77, 12)
        Me.Label63.TabIndex = 23
        Me.Label63.Text = "Recipe Type:"
        '
        'txt_ship_id
        '
        Me.txt_ship_id.ForeColor = System.Drawing.Color.Red
        Me.txt_ship_id.Location = New System.Drawing.Point(129, 29)
        Me.txt_ship_id.Name = "txt_ship_id"
        Me.txt_ship_id.ReadOnly = True
        Me.txt_ship_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_ship_id.TabIndex = 22
        Me.txt_ship_id.Text = "R"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(48, 34)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(65, 12)
        Me.Label64.TabIndex = 21
        Me.Label64.Text = "Recipe ID:"
        '
        'txt_ship_REMARK
        '
        Me.txt_ship_REMARK.Location = New System.Drawing.Point(38, 152)
        Me.txt_ship_REMARK.Multiline = True
        Me.txt_ship_REMARK.Name = "txt_ship_REMARK"
        Me.txt_ship_REMARK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_ship_REMARK.Size = New System.Drawing.Size(716, 82)
        Me.txt_ship_REMARK.TabIndex = 18
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(34, 114)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(71, 12)
        Me.Label65.TabIndex = 15
        Me.Label65.Text = "1. Remark :"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.combo_SHIP_stagequery)
        Me.GroupBox17.Controls.Add(Me.combo_ship_query)
        Me.GroupBox17.Controls.Add(Me.btn_ship_query)
        Me.GroupBox17.Controls.Add(Me.btn_ship_delete)
        Me.GroupBox17.Controls.Add(Me.btn_ship_disable)
        Me.GroupBox17.Controls.Add(Me.btn_ship_copy)
        Me.GroupBox17.Controls.Add(Me.btn_ship_modify)
        Me.GroupBox17.Controls.Add(Me.btn_ship_new)
        Me.GroupBox17.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox17.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox17.TabIndex = 26
        Me.GroupBox17.TabStop = False
        '
        'combo_SHIP_stagequery
        '
        Me.combo_SHIP_stagequery.FormattingEnabled = True
        Me.combo_SHIP_stagequery.Location = New System.Drawing.Point(139, 32)
        Me.combo_SHIP_stagequery.Name = "combo_SHIP_stagequery"
        Me.combo_SHIP_stagequery.Size = New System.Drawing.Size(80, 20)
        Me.combo_SHIP_stagequery.TabIndex = 8
        Me.combo_SHIP_stagequery.Text = "ALL"
        '
        'combo_ship_query
        '
        Me.combo_ship_query.FormattingEnabled = True
        Me.combo_ship_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_ship_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_ship_query.Name = "combo_ship_query"
        Me.combo_ship_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_ship_query.TabIndex = 6
        Me.combo_ship_query.Text = "ENABLE"
        '
        'btn_ship_query
        '
        Me.btn_ship_query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_query.ForeColor = System.Drawing.Color.Black
        Me.btn_ship_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_ship_query.Location = New System.Drawing.Point(330, 20)
        Me.btn_ship_query.Name = "btn_ship_query"
        Me.btn_ship_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_query.TabIndex = 5
        Me.btn_ship_query.UseVisualStyleBackColor = False
        '
        'btn_ship_delete
        '
        Me.btn_ship_delete.BackColor = System.Drawing.Color.Red
        Me.btn_ship_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_ship_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_ship_delete.Name = "btn_ship_delete"
        Me.btn_ship_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_delete.TabIndex = 4
        Me.btn_ship_delete.UseVisualStyleBackColor = False
        Me.btn_ship_delete.Visible = False
        '
        'btn_ship_disable
        '
        Me.btn_ship_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_ship_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_ship_disable.Name = "btn_ship_disable"
        Me.btn_ship_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_disable.TabIndex = 3
        Me.btn_ship_disable.UseVisualStyleBackColor = False
        '
        'btn_ship_copy
        '
        Me.btn_ship_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_ship_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_ship_copy.Name = "btn_ship_copy"
        Me.btn_ship_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_copy.TabIndex = 2
        Me.btn_ship_copy.UseVisualStyleBackColor = False
        '
        'btn_ship_modify
        '
        Me.btn_ship_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_ship_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_ship_modify.Name = "btn_ship_modify"
        Me.btn_ship_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_modify.TabIndex = 1
        Me.btn_ship_modify.UseVisualStyleBackColor = False
        '
        'btn_ship_new
        '
        Me.btn_ship_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_ship_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_ship_new.Name = "btn_ship_new"
        Me.btn_ship_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_new.TabIndex = 0
        Me.btn_ship_new.UseVisualStyleBackColor = False
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.DGV_SHIP)
        Me.GroupBox16.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox16.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox16.TabIndex = 23
        Me.GroupBox16.TabStop = False
        '
        'DGV_SHIP
        '
        Me.DGV_SHIP.AllowUserToAddRows = False
        Me.DGV_SHIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SHIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_SHIP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_SHIP.Location = New System.Drawing.Point(3, 17)
        Me.DGV_SHIP.Name = "DGV_SHIP"
        Me.DGV_SHIP.ReadOnly = True
        Me.DGV_SHIP.RowHeadersVisible = False
        Me.DGV_SHIP.RowTemplate.Height = 23
        Me.DGV_SHIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_SHIP.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_SHIP.TabIndex = 0
        '
        'PACK
        '
        Me.PACK.Controls.Add(Me.grp_pack_para)
        Me.PACK.Controls.Add(Me.GroupBox15)
        Me.PACK.Controls.Add(Me.GroupBox14)
        Me.PACK.Location = New System.Drawing.Point(4, 24)
        Me.PACK.Name = "PACK"
        Me.PACK.Padding = New System.Windows.Forms.Padding(3)
        Me.PACK.Size = New System.Drawing.Size(1215, 932)
        Me.PACK.TabIndex = 3
        Me.PACK.Text = "PACK"
        Me.PACK.UseVisualStyleBackColor = True
        '
        'grp_pack_para
        '
        Me.grp_pack_para.Controls.Add(Me.Panel9)
        Me.grp_pack_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_pack_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_pack_para.Name = "grp_pack_para"
        Me.grp_pack_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_pack_para.TabIndex = 24
        Me.grp_pack_para.TabStop = False
        Me.grp_pack_para.Text = "Parameters"
        Me.grp_pack_para.Visible = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txt_pack_packinfo)
        Me.Panel9.Controls.Add(Me.txt_pack_duetime)
        Me.Panel9.Controls.Add(Me.Label99)
        Me.Panel9.Controls.Add(Me.txt_pack_msl)
        Me.Panel9.Controls.Add(Me.Label98)
        Me.Panel9.Controls.Add(Me.txt_pack_traystacking)
        Me.Panel9.Controls.Add(Me.Label58)
        Me.Panel9.Controls.Add(Me.txt_pack_packingjob)
        Me.Panel9.Controls.Add(Me.Label95)
        Me.Panel9.Controls.Add(Me.Label68)
        Me.Panel9.Controls.Add(Me.btn_pack_exit)
        Me.Panel9.Controls.Add(Me.btn_pack_confirm)
        Me.Panel9.Controls.Add(Me.txt_pack_lot)
        Me.Panel9.Controls.Add(Me.Label56)
        Me.Panel9.Controls.Add(Me.combo_pack_type)
        Me.Panel9.Controls.Add(Me.Label59)
        Me.Panel9.Controls.Add(Me.txt_pack_id)
        Me.Panel9.Controls.Add(Me.Label60)
        Me.Panel9.Controls.Add(Me.txt_pack_remark)
        Me.Panel9.Controls.Add(Me.Label62)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 17)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1203, 636)
        Me.Panel9.TabIndex = 29
        '
        'txt_pack_packinfo
        '
        Me.txt_pack_packinfo.Location = New System.Drawing.Point(58, 201)
        Me.txt_pack_packinfo.Multiline = True
        Me.txt_pack_packinfo.Name = "txt_pack_packinfo"
        Me.txt_pack_packinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_pack_packinfo.Size = New System.Drawing.Size(716, 82)
        Me.txt_pack_packinfo.TabIndex = 260
        '
        'txt_pack_duetime
        '
        Me.txt_pack_duetime.Location = New System.Drawing.Point(769, 144)
        Me.txt_pack_duetime.Name = "txt_pack_duetime"
        Me.txt_pack_duetime.Size = New System.Drawing.Size(162, 21)
        Me.txt_pack_duetime.TabIndex = 259
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(683, 147)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(59, 12)
        Me.Label99.TabIndex = 258
        Me.Label99.Text = "due time:"
        '
        'txt_pack_msl
        '
        Me.txt_pack_msl.Location = New System.Drawing.Point(769, 112)
        Me.txt_pack_msl.Name = "txt_pack_msl"
        Me.txt_pack_msl.Size = New System.Drawing.Size(162, 21)
        Me.txt_pack_msl.TabIndex = 257
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(683, 115)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(29, 12)
        Me.Label98.TabIndex = 256
        Me.Label98.Text = "MSL:"
        '
        'txt_pack_traystacking
        '
        Me.txt_pack_traystacking.Location = New System.Drawing.Point(769, 74)
        Me.txt_pack_traystacking.Name = "txt_pack_traystacking"
        Me.txt_pack_traystacking.Size = New System.Drawing.Size(162, 21)
        Me.txt_pack_traystacking.TabIndex = 255
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(683, 77)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(83, 12)
        Me.Label58.TabIndex = 254
        Me.Label58.Text = "TrayStacking:"
        '
        'txt_pack_packingjob
        '
        Me.txt_pack_packingjob.Location = New System.Drawing.Point(769, 41)
        Me.txt_pack_packingjob.Name = "txt_pack_packingjob"
        Me.txt_pack_packingjob.Size = New System.Drawing.Size(162, 21)
        Me.txt_pack_packingjob.TabIndex = 253
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(683, 44)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(71, 12)
        Me.Label95.TabIndex = 252
        Me.Label95.Text = "packingjob:"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(56, 166)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(83, 12)
        Me.Label68.TabIndex = 53
        Me.Label68.Text = "1. 包材信息 :"
        '
        'btn_pack_exit
        '
        Me.btn_pack_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_pack_exit.Location = New System.Drawing.Point(503, 513)
        Me.btn_pack_exit.Name = "btn_pack_exit"
        Me.btn_pack_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_exit.TabIndex = 38
        Me.btn_pack_exit.UseVisualStyleBackColor = True
        '
        'btn_pack_confirm
        '
        Me.btn_pack_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_pack_confirm.Location = New System.Drawing.Point(127, 513)
        Me.btn_pack_confirm.Name = "btn_pack_confirm"
        Me.btn_pack_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_confirm.TabIndex = 37
        Me.btn_pack_confirm.UseVisualStyleBackColor = True
        '
        'txt_pack_lot
        '
        Me.txt_pack_lot.Location = New System.Drawing.Point(435, 44)
        Me.txt_pack_lot.Multiline = True
        Me.txt_pack_lot.Name = "txt_pack_lot"
        Me.txt_pack_lot.ReadOnly = True
        Me.txt_pack_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_pack_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_pack_lot.TabIndex = 36
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(391, 49)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(35, 12)
        Me.Label56.TabIndex = 35
        Me.Label56.Text = "LOT :"
        '
        'combo_pack_type
        '
        Me.combo_pack_type.FormattingEnabled = True
        Me.combo_pack_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_pack_type.Location = New System.Drawing.Point(151, 78)
        Me.combo_pack_type.Name = "combo_pack_type"
        Me.combo_pack_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_pack_type.TabIndex = 34
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(58, 78)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(77, 12)
        Me.Label59.TabIndex = 33
        Me.Label59.Text = "Recipe Type:"
        '
        'txt_pack_id
        '
        Me.txt_pack_id.ForeColor = System.Drawing.Color.Red
        Me.txt_pack_id.Location = New System.Drawing.Point(151, 46)
        Me.txt_pack_id.Name = "txt_pack_id"
        Me.txt_pack_id.ReadOnly = True
        Me.txt_pack_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_pack_id.TabIndex = 32
        Me.txt_pack_id.Text = "R"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(70, 51)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(65, 12)
        Me.Label60.TabIndex = 31
        Me.Label60.Text = "Recipe ID:"
        '
        'txt_pack_remark
        '
        Me.txt_pack_remark.Location = New System.Drawing.Point(60, 336)
        Me.txt_pack_remark.Multiline = True
        Me.txt_pack_remark.Name = "txt_pack_remark"
        Me.txt_pack_remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_pack_remark.Size = New System.Drawing.Size(716, 82)
        Me.txt_pack_remark.TabIndex = 30
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(56, 298)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(71, 12)
        Me.Label62.TabIndex = 29
        Me.Label62.Text = "2. remark :"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.combo_pack_query)
        Me.GroupBox15.Controls.Add(Me.btn_pack_query)
        Me.GroupBox15.Controls.Add(Me.btn_pack_delete)
        Me.GroupBox15.Controls.Add(Me.btn_pack_disable)
        Me.GroupBox15.Controls.Add(Me.btn_pack_copy)
        Me.GroupBox15.Controls.Add(Me.btn_pack_modify)
        Me.GroupBox15.Controls.Add(Me.btn_pack_new)
        Me.GroupBox15.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox15.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox15.TabIndex = 23
        Me.GroupBox15.TabStop = False
        '
        'combo_pack_query
        '
        Me.combo_pack_query.FormattingEnabled = True
        Me.combo_pack_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_pack_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_pack_query.Name = "combo_pack_query"
        Me.combo_pack_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_pack_query.TabIndex = 6
        Me.combo_pack_query.Text = "ENABLE"
        '
        'btn_pack_query
        '
        Me.btn_pack_query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_query.ForeColor = System.Drawing.Color.Black
        Me.btn_pack_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_pack_query.Location = New System.Drawing.Point(330, 20)
        Me.btn_pack_query.Name = "btn_pack_query"
        Me.btn_pack_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_query.TabIndex = 5
        Me.btn_pack_query.UseVisualStyleBackColor = False
        '
        'btn_pack_delete
        '
        Me.btn_pack_delete.BackColor = System.Drawing.Color.Red
        Me.btn_pack_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_pack_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_pack_delete.Name = "btn_pack_delete"
        Me.btn_pack_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_delete.TabIndex = 4
        Me.btn_pack_delete.UseVisualStyleBackColor = False
        Me.btn_pack_delete.Visible = False
        '
        'btn_pack_disable
        '
        Me.btn_pack_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_pack_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_pack_disable.Name = "btn_pack_disable"
        Me.btn_pack_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_disable.TabIndex = 3
        Me.btn_pack_disable.UseVisualStyleBackColor = False
        '
        'btn_pack_copy
        '
        Me.btn_pack_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_pack_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_pack_copy.Name = "btn_pack_copy"
        Me.btn_pack_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_copy.TabIndex = 2
        Me.btn_pack_copy.UseVisualStyleBackColor = False
        '
        'btn_pack_modify
        '
        Me.btn_pack_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_pack_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_pack_modify.Name = "btn_pack_modify"
        Me.btn_pack_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_modify.TabIndex = 1
        Me.btn_pack_modify.UseVisualStyleBackColor = False
        '
        'btn_pack_new
        '
        Me.btn_pack_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_pack_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_pack_new.Name = "btn_pack_new"
        Me.btn_pack_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_new.TabIndex = 0
        Me.btn_pack_new.UseVisualStyleBackColor = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.DGV_PACK)
        Me.GroupBox14.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox14.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox14.TabIndex = 20
        Me.GroupBox14.TabStop = False
        '
        'DGV_PACK
        '
        Me.DGV_PACK.AllowUserToAddRows = False
        Me.DGV_PACK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PACK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_PACK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_PACK.Location = New System.Drawing.Point(3, 17)
        Me.DGV_PACK.Name = "DGV_PACK"
        Me.DGV_PACK.ReadOnly = True
        Me.DGV_PACK.RowHeadersVisible = False
        Me.DGV_PACK.RowTemplate.Height = 23
        Me.DGV_PACK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PACK.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_PACK.TabIndex = 0
        '
        'FQC
        '
        Me.FQC.Controls.Add(Me.grp_FQC_para)
        Me.FQC.Controls.Add(Me.GroupBox8)
        Me.FQC.Controls.Add(Me.GroupBox7)
        Me.FQC.Location = New System.Drawing.Point(4, 24)
        Me.FQC.Name = "FQC"
        Me.FQC.Padding = New System.Windows.Forms.Padding(3)
        Me.FQC.Size = New System.Drawing.Size(1215, 932)
        Me.FQC.TabIndex = 2
        Me.FQC.Text = "FQC"
        Me.FQC.UseVisualStyleBackColor = True
        '
        'grp_FQC_para
        '
        Me.grp_FQC_para.Controls.Add(Me.Panel8)
        Me.grp_FQC_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_FQC_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_FQC_para.Name = "grp_FQC_para"
        Me.grp_FQC_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_FQC_para.TabIndex = 21
        Me.grp_FQC_para.TabStop = False
        Me.grp_FQC_para.Text = "Parameters"
        Me.grp_FQC_para.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txt_FQC_traystacking)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.txt_FQC_stage)
        Me.Panel8.Controls.Add(Me.Label73)
        Me.Panel8.Controls.Add(Me.txt_FQC_Remark)
        Me.Panel8.Controls.Add(Me.Label19)
        Me.Panel8.Controls.Add(Me.btn_FQC_exit)
        Me.Panel8.Controls.Add(Me.btn_FQC_confirm)
        Me.Panel8.Controls.Add(Me.txt_FQC_lot)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.combo_FQC_type)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.txt_FQC_ID)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.txt_FQC_Attention)
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Controls.Add(Me.txt_FQC_SampleSize)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 17)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1203, 636)
        Me.Panel8.TabIndex = 31
        '
        'txt_FQC_traystacking
        '
        Me.txt_FQC_traystacking.Location = New System.Drawing.Point(468, 56)
        Me.txt_FQC_traystacking.Name = "txt_FQC_traystacking"
        Me.txt_FQC_traystacking.Size = New System.Drawing.Size(162, 21)
        Me.txt_FQC_traystacking.TabIndex = 251
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(382, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 12)
        Me.Label13.TabIndex = 250
        Me.Label13.Text = "TrayStacking:"
        '
        'txt_FQC_stage
        '
        Me.txt_FQC_stage.Location = New System.Drawing.Point(468, 23)
        Me.txt_FQC_stage.Name = "txt_FQC_stage"
        Me.txt_FQC_stage.Size = New System.Drawing.Size(162, 21)
        Me.txt_FQC_stage.TabIndex = 249
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(382, 26)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(41, 12)
        Me.Label73.TabIndex = 248
        Me.Label73.Text = "Stage:"
        '
        'txt_FQC_Remark
        '
        Me.txt_FQC_Remark.Location = New System.Drawing.Point(63, 485)
        Me.txt_FQC_Remark.Multiline = True
        Me.txt_FQC_Remark.Name = "txt_FQC_Remark"
        Me.txt_FQC_Remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FQC_Remark.Size = New System.Drawing.Size(716, 49)
        Me.txt_FQC_Remark.TabIndex = 46
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(61, 458)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 12)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "3.Remark"
        '
        'btn_FQC_exit
        '
        Me.btn_FQC_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_FQC_exit.Location = New System.Drawing.Point(494, 556)
        Me.btn_FQC_exit.Name = "btn_FQC_exit"
        Me.btn_FQC_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_exit.TabIndex = 44
        Me.btn_FQC_exit.UseVisualStyleBackColor = True
        '
        'btn_FQC_confirm
        '
        Me.btn_FQC_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_FQC_confirm.Location = New System.Drawing.Point(191, 556)
        Me.btn_FQC_confirm.Name = "btn_FQC_confirm"
        Me.btn_FQC_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_confirm.TabIndex = 43
        Me.btn_FQC_confirm.UseVisualStyleBackColor = True
        '
        'txt_FQC_lot
        '
        Me.txt_FQC_lot.Location = New System.Drawing.Point(132, 97)
        Me.txt_FQC_lot.Multiline = True
        Me.txt_FQC_lot.Name = "txt_FQC_lot"
        Me.txt_FQC_lot.ReadOnly = True
        Me.txt_FQC_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_FQC_lot.Size = New System.Drawing.Size(162, 54)
        Me.txt_FQC_lot.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 12)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "LOT :"
        '
        'combo_FQC_type
        '
        Me.combo_FQC_type.FormattingEnabled = True
        Me.combo_FQC_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_FQC_type.Location = New System.Drawing.Point(132, 57)
        Me.combo_FQC_type.Name = "combo_FQC_type"
        Me.combo_FQC_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_FQC_type.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 12)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Recipe Type:"
        '
        'txt_FQC_ID
        '
        Me.txt_FQC_ID.ForeColor = System.Drawing.Color.Red
        Me.txt_FQC_ID.Location = New System.Drawing.Point(132, 25)
        Me.txt_FQC_ID.Name = "txt_FQC_ID"
        Me.txt_FQC_ID.ReadOnly = True
        Me.txt_FQC_ID.Size = New System.Drawing.Size(162, 21)
        Me.txt_FQC_ID.TabIndex = 38
        Me.txt_FQC_ID.Text = "R"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Recipe ID:"
        '
        'txt_FQC_Attention
        '
        Me.txt_FQC_Attention.Location = New System.Drawing.Point(61, 380)
        Me.txt_FQC_Attention.Multiline = True
        Me.txt_FQC_Attention.Name = "txt_FQC_Attention"
        Me.txt_FQC_Attention.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FQC_Attention.Size = New System.Drawing.Size(716, 61)
        Me.txt_FQC_Attention.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(59, 355)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 12)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "2.注意事项"
        '
        'txt_FQC_SampleSize
        '
        Me.txt_FQC_SampleSize.Location = New System.Drawing.Point(61, 255)
        Me.txt_FQC_SampleSize.Multiline = True
        Me.txt_FQC_SampleSize.Name = "txt_FQC_SampleSize"
        Me.txt_FQC_SampleSize.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FQC_SampleSize.Size = New System.Drawing.Size(716, 72)
        Me.txt_FQC_SampleSize.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(59, 231)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(179, 12)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "1. IQC Sampling Size 抽样数量"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.combo_FQC_query)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_query)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_delete)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_disable)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_copy)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_modify)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_new)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox8.TabIndex = 20
        Me.GroupBox8.TabStop = False
        '
        'combo_FQC_query
        '
        Me.combo_FQC_query.FormattingEnabled = True
        Me.combo_FQC_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_FQC_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_FQC_query.Name = "combo_FQC_query"
        Me.combo_FQC_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_FQC_query.TabIndex = 6
        Me.combo_FQC_query.Text = "ENABLE"
        '
        'btn_FQC_query
        '
        Me.btn_FQC_query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_query.ForeColor = System.Drawing.Color.Black
        Me.btn_FQC_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_FQC_query.Location = New System.Drawing.Point(330, 20)
        Me.btn_FQC_query.Name = "btn_FQC_query"
        Me.btn_FQC_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_query.TabIndex = 5
        Me.btn_FQC_query.UseVisualStyleBackColor = False
        '
        'btn_FQC_delete
        '
        Me.btn_FQC_delete.BackColor = System.Drawing.Color.Red
        Me.btn_FQC_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_FQC_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_FQC_delete.Name = "btn_FQC_delete"
        Me.btn_FQC_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_delete.TabIndex = 4
        Me.btn_FQC_delete.UseVisualStyleBackColor = False
        Me.btn_FQC_delete.Visible = False
        '
        'btn_FQC_disable
        '
        Me.btn_FQC_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_FQC_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_FQC_disable.Name = "btn_FQC_disable"
        Me.btn_FQC_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_disable.TabIndex = 3
        Me.btn_FQC_disable.UseVisualStyleBackColor = False
        '
        'btn_FQC_copy
        '
        Me.btn_FQC_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_FQC_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_FQC_copy.Name = "btn_FQC_copy"
        Me.btn_FQC_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_copy.TabIndex = 2
        Me.btn_FQC_copy.UseVisualStyleBackColor = False
        '
        'btn_FQC_modify
        '
        Me.btn_FQC_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_FQC_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_FQC_modify.Name = "btn_FQC_modify"
        Me.btn_FQC_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_modify.TabIndex = 1
        Me.btn_FQC_modify.UseVisualStyleBackColor = False
        '
        'btn_FQC_new
        '
        Me.btn_FQC_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_FQC_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_FQC_new.Name = "btn_FQC_new"
        Me.btn_FQC_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_new.TabIndex = 0
        Me.btn_FQC_new.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DGV_FQC)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        '
        'DGV_FQC
        '
        Me.DGV_FQC.AllowUserToAddRows = False
        Me.DGV_FQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_FQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_FQC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_FQC.Location = New System.Drawing.Point(3, 17)
        Me.DGV_FQC.Name = "DGV_FQC"
        Me.DGV_FQC.ReadOnly = True
        Me.DGV_FQC.RowHeadersVisible = False
        Me.DGV_FQC.RowTemplate.Height = 23
        Me.DGV_FQC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_FQC.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_FQC.TabIndex = 0
        '
        'SCANVM
        '
        Me.SCANVM.Controls.Add(Me.grp_wipfs_para)
        Me.SCANVM.Controls.Add(Me.GroupBox13)
        Me.SCANVM.Controls.Add(Me.GroupBox12)
        Me.SCANVM.Location = New System.Drawing.Point(4, 24)
        Me.SCANVM.Name = "SCANVM"
        Me.SCANVM.Padding = New System.Windows.Forms.Padding(3)
        Me.SCANVM.Size = New System.Drawing.Size(1215, 932)
        Me.SCANVM.TabIndex = 6
        Me.SCANVM.Text = "SCAN/VM"
        Me.SCANVM.UseVisualStyleBackColor = True
        '
        'grp_wipfs_para
        '
        Me.grp_wipfs_para.Controls.Add(Me.Panel7)
        Me.grp_wipfs_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_wipfs_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_wipfs_para.Name = "grp_wipfs_para"
        Me.grp_wipfs_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_wipfs_para.TabIndex = 21
        Me.grp_wipfs_para.TabStop = False
        Me.grp_wipfs_para.Text = "Parameters"
        Me.grp_wipfs_para.Visible = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txt_scanvm_yieldlimit)
        Me.Panel7.Controls.Add(Me.Label84)
        Me.Panel7.Controls.Add(Me.txt_scanvm_traystacking)
        Me.Panel7.Controls.Add(Me.Label45)
        Me.Panel7.Controls.Add(Me.txt_scanvm_scanjob)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.btn_scanvm_exit)
        Me.Panel7.Controls.Add(Me.btn_scanvm_confirm)
        Me.Panel7.Controls.Add(Me.txt_scanvm_lot)
        Me.Panel7.Controls.Add(Me.Label47)
        Me.Panel7.Controls.Add(Me.combo_scanvm_type)
        Me.Panel7.Controls.Add(Me.Label52)
        Me.Panel7.Controls.Add(Me.txt_scanvm_id)
        Me.Panel7.Controls.Add(Me.Label55)
        Me.Panel7.Controls.Add(Me.txt_scanvm_remark)
        Me.Panel7.Controls.Add(Me.Label57)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 17)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1203, 636)
        Me.Panel7.TabIndex = 30
        '
        'txt_scanvm_yieldlimit
        '
        Me.txt_scanvm_yieldlimit.Location = New System.Drawing.Point(434, 65)
        Me.txt_scanvm_yieldlimit.Name = "txt_scanvm_yieldlimit"
        Me.txt_scanvm_yieldlimit.Size = New System.Drawing.Size(162, 21)
        Me.txt_scanvm_yieldlimit.TabIndex = 204
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(343, 71)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(77, 12)
        Me.Label84.TabIndex = 203
        Me.Label84.Text = "Yield Limit:"
        '
        'txt_scanvm_traystacking
        '
        Me.txt_scanvm_traystacking.Location = New System.Drawing.Point(434, 27)
        Me.txt_scanvm_traystacking.Name = "txt_scanvm_traystacking"
        Me.txt_scanvm_traystacking.Size = New System.Drawing.Size(162, 21)
        Me.txt_scanvm_traystacking.TabIndex = 202
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(343, 33)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(89, 12)
        Me.Label45.TabIndex = 201
        Me.Label45.Text = "Tray Stacking:"
        '
        'txt_scanvm_scanjob
        '
        Me.txt_scanvm_scanjob.Location = New System.Drawing.Point(434, 110)
        Me.txt_scanvm_scanjob.Name = "txt_scanvm_scanjob"
        Me.txt_scanvm_scanjob.Size = New System.Drawing.Size(162, 21)
        Me.txt_scanvm_scanjob.TabIndex = 200
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "Scan Job:"
        '
        'btn_scanvm_exit
        '
        Me.btn_scanvm_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_scanvm_exit.Location = New System.Drawing.Point(515, 393)
        Me.btn_scanvm_exit.Name = "btn_scanvm_exit"
        Me.btn_scanvm_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_scanvm_exit.TabIndex = 40
        Me.btn_scanvm_exit.UseVisualStyleBackColor = True
        '
        'btn_scanvm_confirm
        '
        Me.btn_scanvm_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_scanvm_confirm.Location = New System.Drawing.Point(139, 393)
        Me.btn_scanvm_confirm.Name = "btn_scanvm_confirm"
        Me.btn_scanvm_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_scanvm_confirm.TabIndex = 39
        Me.btn_scanvm_confirm.UseVisualStyleBackColor = True
        '
        'txt_scanvm_lot
        '
        Me.txt_scanvm_lot.Location = New System.Drawing.Point(139, 101)
        Me.txt_scanvm_lot.Multiline = True
        Me.txt_scanvm_lot.Name = "txt_scanvm_lot"
        Me.txt_scanvm_lot.ReadOnly = True
        Me.txt_scanvm_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_scanvm_lot.Size = New System.Drawing.Size(162, 54)
        Me.txt_scanvm_lot.TabIndex = 38
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(88, 101)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(35, 12)
        Me.Label47.TabIndex = 37
        Me.Label47.Text = "LOT :"
        '
        'combo_scanvm_type
        '
        Me.combo_scanvm_type.FormattingEnabled = True
        Me.combo_scanvm_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_scanvm_type.Location = New System.Drawing.Point(139, 59)
        Me.combo_scanvm_type.Name = "combo_scanvm_type"
        Me.combo_scanvm_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_scanvm_type.TabIndex = 36
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(46, 59)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(77, 12)
        Me.Label52.TabIndex = 35
        Me.Label52.Text = "Recipe Type:"
        '
        'txt_scanvm_id
        '
        Me.txt_scanvm_id.ForeColor = System.Drawing.Color.Red
        Me.txt_scanvm_id.Location = New System.Drawing.Point(139, 27)
        Me.txt_scanvm_id.Name = "txt_scanvm_id"
        Me.txt_scanvm_id.ReadOnly = True
        Me.txt_scanvm_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_scanvm_id.TabIndex = 34
        Me.txt_scanvm_id.Text = "R"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(58, 32)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(65, 12)
        Me.Label55.TabIndex = 33
        Me.Label55.Text = "Recipe ID:"
        '
        'txt_scanvm_remark
        '
        Me.txt_scanvm_remark.Location = New System.Drawing.Point(48, 238)
        Me.txt_scanvm_remark.Multiline = True
        Me.txt_scanvm_remark.Name = "txt_scanvm_remark"
        Me.txt_scanvm_remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_scanvm_remark.Size = New System.Drawing.Size(716, 82)
        Me.txt_scanvm_remark.TabIndex = 32
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(46, 213)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(65, 12)
        Me.Label57.TabIndex = 31
        Me.Label57.Text = "1. Remark:"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.combo_scanvm_query)
        Me.GroupBox13.Controls.Add(Me.btn_scanvm_Query)
        Me.GroupBox13.Controls.Add(Me.btn_scanvm_delete)
        Me.GroupBox13.Controls.Add(Me.btn_scanvm_disable)
        Me.GroupBox13.Controls.Add(Me.btn_scanvm_copy)
        Me.GroupBox13.Controls.Add(Me.btn_scanvm_modify)
        Me.GroupBox13.Controls.Add(Me.btn_scanvm_new)
        Me.GroupBox13.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox13.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox13.TabIndex = 20
        Me.GroupBox13.TabStop = False
        '
        'combo_scanvm_query
        '
        Me.combo_scanvm_query.FormattingEnabled = True
        Me.combo_scanvm_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_scanvm_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_scanvm_query.Name = "combo_scanvm_query"
        Me.combo_scanvm_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_scanvm_query.TabIndex = 6
        Me.combo_scanvm_query.Text = "ENABLE"
        '
        'btn_scanvm_Query
        '
        Me.btn_scanvm_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_scanvm_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_scanvm_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_scanvm_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_scanvm_Query.Name = "btn_scanvm_Query"
        Me.btn_scanvm_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_scanvm_Query.TabIndex = 5
        Me.btn_scanvm_Query.UseVisualStyleBackColor = False
        '
        'btn_scanvm_delete
        '
        Me.btn_scanvm_delete.BackColor = System.Drawing.Color.Red
        Me.btn_scanvm_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_scanvm_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_scanvm_delete.Name = "btn_scanvm_delete"
        Me.btn_scanvm_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_scanvm_delete.TabIndex = 4
        Me.btn_scanvm_delete.UseVisualStyleBackColor = False
        Me.btn_scanvm_delete.Visible = False
        '
        'btn_scanvm_disable
        '
        Me.btn_scanvm_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_scanvm_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_scanvm_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_scanvm_disable.Name = "btn_scanvm_disable"
        Me.btn_scanvm_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_scanvm_disable.TabIndex = 3
        Me.btn_scanvm_disable.UseVisualStyleBackColor = False
        '
        'btn_scanvm_copy
        '
        Me.btn_scanvm_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_scanvm_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_scanvm_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_scanvm_copy.Name = "btn_scanvm_copy"
        Me.btn_scanvm_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_scanvm_copy.TabIndex = 2
        Me.btn_scanvm_copy.UseVisualStyleBackColor = False
        '
        'btn_scanvm_modify
        '
        Me.btn_scanvm_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_scanvm_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_scanvm_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_scanvm_modify.Name = "btn_scanvm_modify"
        Me.btn_scanvm_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_scanvm_modify.TabIndex = 1
        Me.btn_scanvm_modify.UseVisualStyleBackColor = False
        '
        'btn_scanvm_new
        '
        Me.btn_scanvm_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_scanvm_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_scanvm_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_scanvm_new.Name = "btn_scanvm_new"
        Me.btn_scanvm_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_scanvm_new.TabIndex = 0
        Me.btn_scanvm_new.UseVisualStyleBackColor = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.DGV_scanvm)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox12.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox12.TabIndex = 17
        Me.GroupBox12.TabStop = False
        '
        'DGV_scanvm
        '
        Me.DGV_scanvm.AllowUserToAddRows = False
        Me.DGV_scanvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_scanvm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_scanvm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_scanvm.Location = New System.Drawing.Point(3, 17)
        Me.DGV_scanvm.Name = "DGV_scanvm"
        Me.DGV_scanvm.ReadOnly = True
        Me.DGV_scanvm.RowHeadersVisible = False
        Me.DGV_scanvm.RowTemplate.Height = 23
        Me.DGV_scanvm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_scanvm.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_scanvm.TabIndex = 0
        '
        'QCn
        '
        Me.QCn.Controls.Add(Me.grp_cpdt_para)
        Me.QCn.Controls.Add(Me.GroupBox11)
        Me.QCn.Controls.Add(Me.GroupBox10)
        Me.QCn.Location = New System.Drawing.Point(4, 24)
        Me.QCn.Name = "QCn"
        Me.QCn.Padding = New System.Windows.Forms.Padding(3)
        Me.QCn.Size = New System.Drawing.Size(1215, 932)
        Me.QCn.TabIndex = 5
        Me.QCn.Text = "QCn"
        Me.QCn.UseVisualStyleBackColor = True
        '
        'grp_cpdt_para
        '
        Me.grp_cpdt_para.Controls.Add(Me.Panel5)
        Me.grp_cpdt_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_cpdt_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_cpdt_para.Name = "grp_cpdt_para"
        Me.grp_cpdt_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_cpdt_para.TabIndex = 24
        Me.grp_cpdt_para.TabStop = False
        Me.grp_cpdt_para.Text = "Parameters"
        Me.grp_cpdt_para.Visible = False
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.txt_QC_samplingsize)
        Me.Panel5.Controls.Add(Me.Label96)
        Me.Panel5.Controls.Add(Me.txt_QC_testtime)
        Me.Panel5.Controls.Add(Me.Label72)
        Me.Panel5.Controls.Add(Me.Combo_QC_FIX3)
        Me.Panel5.Controls.Add(Me.Combo_QC_FIX2)
        Me.Panel5.Controls.Add(Me.Combo_QC_FIX1)
        Me.Panel5.Controls.Add(Me.Combo_QC_AUTO3)
        Me.Panel5.Controls.Add(Me.Combo_QC_AUTO2)
        Me.Panel5.Controls.Add(Me.Combo_QC_AUTO1)
        Me.Panel5.Controls.Add(Me.ChkB6_QC)
        Me.Panel5.Controls.Add(Me.ChkB5_QC)
        Me.Panel5.Controls.Add(Me.ChkB4_QC)
        Me.Panel5.Controls.Add(Me.ChkB3_QC)
        Me.Panel5.Controls.Add(Me.ChkB2_QC)
        Me.Panel5.Controls.Add(Me.ChkB1_QC)
        Me.Panel5.Controls.Add(Me.Label74)
        Me.Panel5.Controls.Add(Me.Label75)
        Me.Panel5.Controls.Add(Me.Label76)
        Me.Panel5.Controls.Add(Me.Label77)
        Me.Panel5.Controls.Add(Me.Label78)
        Me.Panel5.Controls.Add(Me.Label79)
        Me.Panel5.Controls.Add(Me.Label80)
        Me.Panel5.Controls.Add(Me.Label81)
        Me.Panel5.Controls.Add(Me.txt_QC_loadboard)
        Me.Panel5.Controls.Add(Me.Label86)
        Me.Panel5.Controls.Add(Me.txt_QC_soaktime)
        Me.Panel5.Controls.Add(Me.Label87)
        Me.Panel5.Controls.Add(Me.txt_QC_temp)
        Me.Panel5.Controls.Add(Me.Label88)
        Me.Panel5.Controls.Add(Me.txt_QC_swrev)
        Me.Panel5.Controls.Add(Me.Label89)
        Me.Panel5.Controls.Add(Me.txt_QC_os)
        Me.Panel5.Controls.Add(Me.Label90)
        Me.Panel5.Controls.Add(Me.txt_QC_testmode)
        Me.Panel5.Controls.Add(Me.Label91)
        Me.Panel5.Controls.Add(Me.txt_QC_setupfile)
        Me.Panel5.Controls.Add(Me.Label92)
        Me.Panel5.Controls.Add(Me.txt_QC_Handler)
        Me.Panel5.Controls.Add(Me.Label93)
        Me.Panel5.Controls.Add(Me.txt_QC_TestFlatform)
        Me.Panel5.Controls.Add(Me.Label94)
        Me.Panel5.Controls.Add(Me.txt_QC_Remark)
        Me.Panel5.Controls.Add(Me.combo_QC_Stage)
        Me.Panel5.Controls.Add(Me.Label48)
        Me.Panel5.Controls.Add(Me.txt_QC_exit)
        Me.Panel5.Controls.Add(Me.txt_QC_confirm)
        Me.Panel5.Controls.Add(Me.txt_QC_lot)
        Me.Panel5.Controls.Add(Me.Label49)
        Me.Panel5.Controls.Add(Me.combo_QC_type)
        Me.Panel5.Controls.Add(Me.Label50)
        Me.Panel5.Controls.Add(Me.txt_QC_id)
        Me.Panel5.Controls.Add(Me.Label51)
        Me.Panel5.Controls.Add(Me.txt_QC_Attention)
        Me.Panel5.Controls.Add(Me.Label53)
        Me.Panel5.Controls.Add(Me.Label54)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1203, 636)
        Me.Panel5.TabIndex = 34
        '
        'txt_QC_samplingsize
        '
        Me.txt_QC_samplingsize.Location = New System.Drawing.Point(62, 309)
        Me.txt_QC_samplingsize.Multiline = True
        Me.txt_QC_samplingsize.Name = "txt_QC_samplingsize"
        Me.txt_QC_samplingsize.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_QC_samplingsize.Size = New System.Drawing.Size(716, 80)
        Me.txt_QC_samplingsize.TabIndex = 249
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(38, 282)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(179, 12)
        Me.Label96.TabIndex = 248
        Me.Label96.Text = "1. IQC Sampling Size 抽样数量"
        '
        'txt_QC_testtime
        '
        Me.txt_QC_testtime.Location = New System.Drawing.Point(771, 205)
        Me.txt_QC_testtime.Name = "txt_QC_testtime"
        Me.txt_QC_testtime.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_testtime.TabIndex = 245
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(687, 210)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(59, 12)
        Me.Label72.TabIndex = 244
        Me.Label72.Text = "TestTime:"
        '
        'Combo_QC_FIX3
        '
        Me.Combo_QC_FIX3.FormattingEnabled = True
        Me.Combo_QC_FIX3.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_QC_FIX3.Location = New System.Drawing.Point(409, 240)
        Me.Combo_QC_FIX3.Name = "Combo_QC_FIX3"
        Me.Combo_QC_FIX3.Size = New System.Drawing.Size(121, 20)
        Me.Combo_QC_FIX3.TabIndex = 243
        '
        'Combo_QC_FIX2
        '
        Me.Combo_QC_FIX2.FormattingEnabled = True
        Me.Combo_QC_FIX2.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_QC_FIX2.Location = New System.Drawing.Point(409, 204)
        Me.Combo_QC_FIX2.Name = "Combo_QC_FIX2"
        Me.Combo_QC_FIX2.Size = New System.Drawing.Size(121, 20)
        Me.Combo_QC_FIX2.TabIndex = 242
        '
        'Combo_QC_FIX1
        '
        Me.Combo_QC_FIX1.FormattingEnabled = True
        Me.Combo_QC_FIX1.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_QC_FIX1.Location = New System.Drawing.Point(409, 163)
        Me.Combo_QC_FIX1.Name = "Combo_QC_FIX1"
        Me.Combo_QC_FIX1.Size = New System.Drawing.Size(121, 20)
        Me.Combo_QC_FIX1.TabIndex = 241
        '
        'Combo_QC_AUTO3
        '
        Me.Combo_QC_AUTO3.FormattingEnabled = True
        Me.Combo_QC_AUTO3.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_QC_AUTO3.Location = New System.Drawing.Point(409, 125)
        Me.Combo_QC_AUTO3.Name = "Combo_QC_AUTO3"
        Me.Combo_QC_AUTO3.Size = New System.Drawing.Size(121, 20)
        Me.Combo_QC_AUTO3.TabIndex = 240
        '
        'Combo_QC_AUTO2
        '
        Me.Combo_QC_AUTO2.FormattingEnabled = True
        Me.Combo_QC_AUTO2.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_QC_AUTO2.Location = New System.Drawing.Point(409, 89)
        Me.Combo_QC_AUTO2.Name = "Combo_QC_AUTO2"
        Me.Combo_QC_AUTO2.Size = New System.Drawing.Size(121, 20)
        Me.Combo_QC_AUTO2.TabIndex = 239
        '
        'Combo_QC_AUTO1
        '
        Me.Combo_QC_AUTO1.FormattingEnabled = True
        Me.Combo_QC_AUTO1.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_QC_AUTO1.Location = New System.Drawing.Point(411, 47)
        Me.Combo_QC_AUTO1.Name = "Combo_QC_AUTO1"
        Me.Combo_QC_AUTO1.Size = New System.Drawing.Size(121, 20)
        Me.Combo_QC_AUTO1.TabIndex = 238
        '
        'ChkB6_QC
        '
        Me.ChkB6_QC.AutoSize = True
        Me.ChkB6_QC.Location = New System.Drawing.Point(567, 245)
        Me.ChkB6_QC.Name = "ChkB6_QC"
        Me.ChkB6_QC.Size = New System.Drawing.Size(54, 16)
        Me.ChkB6_QC.TabIndex = 237
        Me.ChkB6_QC.Text = "Error"
        Me.ChkB6_QC.UseVisualStyleBackColor = True
        '
        'ChkB5_QC
        '
        Me.ChkB5_QC.AutoSize = True
        Me.ChkB5_QC.Location = New System.Drawing.Point(567, 207)
        Me.ChkB5_QC.Name = "ChkB5_QC"
        Me.ChkB5_QC.Size = New System.Drawing.Size(54, 16)
        Me.ChkB5_QC.TabIndex = 236
        Me.ChkB5_QC.Text = "Error"
        Me.ChkB5_QC.UseVisualStyleBackColor = True
        '
        'ChkB4_QC
        '
        Me.ChkB4_QC.AutoSize = True
        Me.ChkB4_QC.Location = New System.Drawing.Point(567, 168)
        Me.ChkB4_QC.Name = "ChkB4_QC"
        Me.ChkB4_QC.Size = New System.Drawing.Size(54, 16)
        Me.ChkB4_QC.TabIndex = 235
        Me.ChkB4_QC.Text = "Error"
        Me.ChkB4_QC.UseVisualStyleBackColor = True
        '
        'ChkB3_QC
        '
        Me.ChkB3_QC.AutoSize = True
        Me.ChkB3_QC.Location = New System.Drawing.Point(567, 127)
        Me.ChkB3_QC.Name = "ChkB3_QC"
        Me.ChkB3_QC.Size = New System.Drawing.Size(54, 16)
        Me.ChkB3_QC.TabIndex = 234
        Me.ChkB3_QC.Text = "Error"
        Me.ChkB3_QC.UseVisualStyleBackColor = True
        '
        'ChkB2_QC
        '
        Me.ChkB2_QC.AutoSize = True
        Me.ChkB2_QC.Location = New System.Drawing.Point(566, 87)
        Me.ChkB2_QC.Name = "ChkB2_QC"
        Me.ChkB2_QC.Size = New System.Drawing.Size(54, 16)
        Me.ChkB2_QC.TabIndex = 233
        Me.ChkB2_QC.Text = "Error"
        Me.ChkB2_QC.UseVisualStyleBackColor = True
        '
        'ChkB1_QC
        '
        Me.ChkB1_QC.AutoSize = True
        Me.ChkB1_QC.Location = New System.Drawing.Point(567, 49)
        Me.ChkB1_QC.Name = "ChkB1_QC"
        Me.ChkB1_QC.Size = New System.Drawing.Size(54, 16)
        Me.ChkB1_QC.TabIndex = 232
        Me.ChkB1_QC.Text = "Error"
        Me.ChkB1_QC.UseVisualStyleBackColor = True
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(698, 14)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(53, 12)
        Me.Label74.TabIndex = 230
        Me.Label74.Text = "作业条件"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(364, 243)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(35, 12)
        Me.Label75.TabIndex = 229
        Me.Label75.Text = "FIX3:"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(364, 207)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(35, 12)
        Me.Label76.TabIndex = 228
        Me.Label76.Text = "FIX2:"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(364, 168)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(35, 12)
        Me.Label77.TabIndex = 227
        Me.Label77.Text = "FIX1:"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(364, 127)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(41, 12)
        Me.Label78.TabIndex = 226
        Me.Label78.Text = "AUTO3:"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(362, 88)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(41, 12)
        Me.Label79.TabIndex = 225
        Me.Label79.Text = "AUTO2:"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(364, 49)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(41, 12)
        Me.Label80.TabIndex = 224
        Me.Label80.Text = "AUTO1:"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(364, 14)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(53, 12)
        Me.Label81.TabIndex = 223
        Me.Label81.Text = "托盘位置"
        '
        'txt_QC_loadboard
        '
        Me.txt_QC_loadboard.Location = New System.Drawing.Point(1026, 201)
        Me.txt_QC_loadboard.Name = "txt_QC_loadboard"
        Me.txt_QC_loadboard.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_loadboard.TabIndex = 214
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(939, 204)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(65, 12)
        Me.Label86.TabIndex = 213
        Me.Label86.Text = "LoadBoard:"
        '
        'txt_QC_soaktime
        '
        Me.txt_QC_soaktime.Location = New System.Drawing.Point(1026, 165)
        Me.txt_QC_soaktime.Name = "txt_QC_soaktime"
        Me.txt_QC_soaktime.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_soaktime.TabIndex = 212
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(939, 168)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(59, 12)
        Me.Label87.TabIndex = 211
        Me.Label87.Text = "SoakTime:"
        '
        'txt_QC_temp
        '
        Me.txt_QC_temp.Location = New System.Drawing.Point(1026, 126)
        Me.txt_QC_temp.Name = "txt_QC_temp"
        Me.txt_QC_temp.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_temp.TabIndex = 210
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(941, 129)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(89, 12)
        Me.Label88.TabIndex = 209
        Me.Label88.Text = "TestTemp(℃)::"
        '
        'txt_QC_swrev
        '
        Me.txt_QC_swrev.Location = New System.Drawing.Point(1026, 89)
        Me.txt_QC_swrev.Name = "txt_QC_swrev"
        Me.txt_QC_swrev.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_swrev.TabIndex = 208
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(941, 92)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(53, 12)
        Me.Label89.TabIndex = 207
        Me.Label89.Text = "S.W Rev:"
        '
        'txt_QC_os
        '
        Me.txt_QC_os.Location = New System.Drawing.Point(1026, 49)
        Me.txt_QC_os.Name = "txt_QC_os"
        Me.txt_QC_os.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_os.TabIndex = 206
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(942, 54)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(23, 12)
        Me.Label90.TabIndex = 205
        Me.Label90.Text = "OS:"
        '
        'txt_QC_testmode
        '
        Me.txt_QC_testmode.Location = New System.Drawing.Point(771, 166)
        Me.txt_QC_testmode.Name = "txt_QC_testmode"
        Me.txt_QC_testmode.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_testmode.TabIndex = 204
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(686, 169)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(65, 12)
        Me.Label91.TabIndex = 203
        Me.Label91.Text = "Test Mode:"
        '
        'txt_QC_setupfile
        '
        Me.txt_QC_setupfile.Location = New System.Drawing.Point(771, 127)
        Me.txt_QC_setupfile.Name = "txt_QC_setupfile"
        Me.txt_QC_setupfile.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_setupfile.TabIndex = 202
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(686, 130)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(65, 12)
        Me.Label92.TabIndex = 201
        Me.Label92.Text = "SetupFile:"
        '
        'txt_QC_Handler
        '
        Me.txt_QC_Handler.Location = New System.Drawing.Point(771, 90)
        Me.txt_QC_Handler.Name = "txt_QC_Handler"
        Me.txt_QC_Handler.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_Handler.TabIndex = 200
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(687, 93)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(53, 12)
        Me.Label93.TabIndex = 199
        Me.Label93.Text = "Handler:"
        '
        'txt_QC_TestFlatform
        '
        Me.txt_QC_TestFlatform.Location = New System.Drawing.Point(771, 49)
        Me.txt_QC_TestFlatform.Name = "txt_QC_TestFlatform"
        Me.txt_QC_TestFlatform.Size = New System.Drawing.Size(134, 21)
        Me.txt_QC_TestFlatform.TabIndex = 198
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(686, 52)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(83, 12)
        Me.Label94.TabIndex = 197
        Me.Label94.Text = "TestPlatform:"
        '
        'txt_QC_Remark
        '
        Me.txt_QC_Remark.Location = New System.Drawing.Point(62, 522)
        Me.txt_QC_Remark.Multiline = True
        Me.txt_QC_Remark.Name = "txt_QC_Remark"
        Me.txt_QC_Remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_QC_Remark.Size = New System.Drawing.Size(716, 60)
        Me.txt_QC_Remark.TabIndex = 47
        '
        'combo_QC_Stage
        '
        Me.combo_QC_Stage.FormattingEnabled = True
        Me.combo_QC_Stage.Location = New System.Drawing.Point(107, 95)
        Me.combo_QC_Stage.Name = "combo_QC_Stage"
        Me.combo_QC_Stage.Size = New System.Drawing.Size(128, 20)
        Me.combo_QC_Stage.TabIndex = 46
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(33, 98)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(41, 12)
        Me.Label48.TabIndex = 45
        Me.Label48.Text = "stage:"
        '
        'txt_QC_exit
        '
        Me.txt_QC_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.txt_QC_exit.Location = New System.Drawing.Point(483, 588)
        Me.txt_QC_exit.Name = "txt_QC_exit"
        Me.txt_QC_exit.Size = New System.Drawing.Size(90, 32)
        Me.txt_QC_exit.TabIndex = 44
        Me.txt_QC_exit.UseVisualStyleBackColor = True
        '
        'txt_QC_confirm
        '
        Me.txt_QC_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.txt_QC_confirm.Location = New System.Drawing.Point(107, 588)
        Me.txt_QC_confirm.Name = "txt_QC_confirm"
        Me.txt_QC_confirm.Size = New System.Drawing.Size(90, 32)
        Me.txt_QC_confirm.TabIndex = 43
        Me.txt_QC_confirm.UseVisualStyleBackColor = True
        '
        'txt_QC_lot
        '
        Me.txt_QC_lot.Location = New System.Drawing.Point(107, 135)
        Me.txt_QC_lot.Multiline = True
        Me.txt_QC_lot.Name = "txt_QC_lot"
        Me.txt_QC_lot.ReadOnly = True
        Me.txt_QC_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_QC_lot.Size = New System.Drawing.Size(162, 54)
        Me.txt_QC_lot.TabIndex = 42
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(33, 152)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(35, 12)
        Me.Label49.TabIndex = 41
        Me.Label49.Text = "LOT :"
        '
        'combo_QC_type
        '
        Me.combo_QC_type.FormattingEnabled = True
        Me.combo_QC_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_QC_type.Location = New System.Drawing.Point(107, 61)
        Me.combo_QC_type.Name = "combo_QC_type"
        Me.combo_QC_type.Size = New System.Drawing.Size(128, 20)
        Me.combo_QC_type.TabIndex = 40
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(33, 64)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(77, 12)
        Me.Label50.TabIndex = 39
        Me.Label50.Text = "Recipe Type:"
        '
        'txt_QC_id
        '
        Me.txt_QC_id.ForeColor = System.Drawing.Color.Red
        Me.txt_QC_id.Location = New System.Drawing.Point(107, 29)
        Me.txt_QC_id.Name = "txt_QC_id"
        Me.txt_QC_id.ReadOnly = True
        Me.txt_QC_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_QC_id.TabIndex = 38
        Me.txt_QC_id.Text = "R"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(32, 32)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(65, 12)
        Me.Label51.TabIndex = 37
        Me.Label51.Text = "Recipe ID:"
        '
        'txt_QC_Attention
        '
        Me.txt_QC_Attention.Location = New System.Drawing.Point(62, 434)
        Me.txt_QC_Attention.Multiline = True
        Me.txt_QC_Attention.Name = "txt_QC_Attention"
        Me.txt_QC_Attention.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_QC_Attention.Size = New System.Drawing.Size(716, 60)
        Me.txt_QC_Attention.TabIndex = 36
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(38, 497)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(65, 12)
        Me.Label53.TabIndex = 35
        Me.Label53.Text = "3. Remark:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(33, 404)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(77, 12)
        Me.Label54.TabIndex = 34
        Me.Label54.Text = "2.注意事项 :"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.combo_QC_stagequery)
        Me.GroupBox11.Controls.Add(Me.combo_QC_enable)
        Me.GroupBox11.Controls.Add(Me.btn_QC_Query)
        Me.GroupBox11.Controls.Add(Me.btn_QC_delete)
        Me.GroupBox11.Controls.Add(Me.btn_QC_disable)
        Me.GroupBox11.Controls.Add(Me.btn_QC_copy)
        Me.GroupBox11.Controls.Add(Me.btn_QC_modify)
        Me.GroupBox11.Controls.Add(Me.btn_QC_new)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox11.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox11.TabIndex = 23
        Me.GroupBox11.TabStop = False
        '
        'combo_QC_stagequery
        '
        Me.combo_QC_stagequery.FormattingEnabled = True
        Me.combo_QC_stagequery.Location = New System.Drawing.Point(140, 32)
        Me.combo_QC_stagequery.Name = "combo_QC_stagequery"
        Me.combo_QC_stagequery.Size = New System.Drawing.Size(80, 20)
        Me.combo_QC_stagequery.TabIndex = 7
        Me.combo_QC_stagequery.Text = "ALL"
        '
        'combo_QC_enable
        '
        Me.combo_QC_enable.FormattingEnabled = True
        Me.combo_QC_enable.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_QC_enable.Location = New System.Drawing.Point(20, 32)
        Me.combo_QC_enable.Name = "combo_QC_enable"
        Me.combo_QC_enable.Size = New System.Drawing.Size(80, 20)
        Me.combo_QC_enable.TabIndex = 6
        Me.combo_QC_enable.Text = "ENABLE"
        '
        'btn_QC_Query
        '
        Me.btn_QC_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_QC_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_QC_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_QC_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_QC_Query.Name = "btn_QC_Query"
        Me.btn_QC_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_QC_Query.TabIndex = 5
        Me.btn_QC_Query.UseVisualStyleBackColor = False
        '
        'btn_QC_delete
        '
        Me.btn_QC_delete.BackColor = System.Drawing.Color.Red
        Me.btn_QC_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_QC_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_QC_delete.Name = "btn_QC_delete"
        Me.btn_QC_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_QC_delete.TabIndex = 4
        Me.btn_QC_delete.UseVisualStyleBackColor = False
        Me.btn_QC_delete.Visible = False
        '
        'btn_QC_disable
        '
        Me.btn_QC_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_QC_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_QC_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_QC_disable.Name = "btn_QC_disable"
        Me.btn_QC_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_QC_disable.TabIndex = 3
        Me.btn_QC_disable.UseVisualStyleBackColor = False
        '
        'btn_QC_copy
        '
        Me.btn_QC_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_QC_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_QC_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_QC_copy.Name = "btn_QC_copy"
        Me.btn_QC_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_QC_copy.TabIndex = 2
        Me.btn_QC_copy.UseVisualStyleBackColor = False
        '
        'btn_QC_modify
        '
        Me.btn_QC_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_QC_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_QC_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_QC_modify.Name = "btn_QC_modify"
        Me.btn_QC_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_QC_modify.TabIndex = 1
        Me.btn_QC_modify.UseVisualStyleBackColor = False
        '
        'btn_QC_new
        '
        Me.btn_QC_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_QC_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_QC_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_QC_new.Name = "btn_QC_new"
        Me.btn_QC_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_QC_new.TabIndex = 0
        Me.btn_QC_new.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.DGV_QC)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox10.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox10.TabIndex = 20
        Me.GroupBox10.TabStop = False
        '
        'DGV_QC
        '
        Me.DGV_QC.AllowUserToAddRows = False
        Me.DGV_QC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_QC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_QC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_QC.Location = New System.Drawing.Point(3, 17)
        Me.DGV_QC.Name = "DGV_QC"
        Me.DGV_QC.ReadOnly = True
        Me.DGV_QC.RowHeadersVisible = False
        Me.DGV_QC.RowTemplate.Height = 23
        Me.DGV_QC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_QC.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_QC.TabIndex = 0
        '
        'BAKE
        '
        Me.BAKE.Controls.Add(Me.grp_bake_para)
        Me.BAKE.Controls.Add(Me.GroupBox9)
        Me.BAKE.Controls.Add(Me.GroupBox6)
        Me.BAKE.Location = New System.Drawing.Point(4, 24)
        Me.BAKE.Name = "BAKE"
        Me.BAKE.Padding = New System.Windows.Forms.Padding(3)
        Me.BAKE.Size = New System.Drawing.Size(1215, 932)
        Me.BAKE.TabIndex = 4
        Me.BAKE.Text = "BAKE"
        Me.BAKE.UseVisualStyleBackColor = True
        '
        'grp_bake_para
        '
        Me.grp_bake_para.Controls.Add(Me.Panel4)
        Me.grp_bake_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_bake_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_bake_para.Name = "grp_bake_para"
        Me.grp_bake_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_bake_para.TabIndex = 21
        Me.grp_bake_para.TabStop = False
        Me.grp_bake_para.Text = "Parameters"
        Me.grp_bake_para.Visible = False
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.txt_bake_GasFlow)
        Me.Panel4.Controls.Add(Me.Label85)
        Me.Panel4.Controls.Add(Me.txt_bake_tempgruve)
        Me.Panel4.Controls.Add(Me.Label97)
        Me.Panel4.Controls.Add(Me.Label82)
        Me.Panel4.Controls.Add(Me.txt_bake_bakingtime)
        Me.Panel4.Controls.Add(Me.Label83)
        Me.Panel4.Controls.Add(Me.Label66)
        Me.Panel4.Controls.Add(Me.Label46)
        Me.Panel4.Controls.Add(Me.txt_bake_baketime)
        Me.Panel4.Controls.Add(Me.combo_bake_recipe)
        Me.Panel4.Controls.Add(Me.btn_bake_exit)
        Me.Panel4.Controls.Add(Me.btn_bake_confirm)
        Me.Panel4.Controls.Add(Me.txt_BAKE_lot)
        Me.Panel4.Controls.Add(Me.Label39)
        Me.Panel4.Controls.Add(Me.combo_BAKE_type)
        Me.Panel4.Controls.Add(Me.Label40)
        Me.Panel4.Controls.Add(Me.txt_BAKE_id)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Controls.Add(Me.txt_bake_remark)
        Me.Panel4.Controls.Add(Me.Label42)
        Me.Panel4.Controls.Add(Me.txt_bake_temp)
        Me.Panel4.Controls.Add(Me.Label43)
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1203, 636)
        Me.Panel4.TabIndex = 37
        '
        'txt_bake_GasFlow
        '
        Me.txt_bake_GasFlow.Location = New System.Drawing.Point(485, 165)
        Me.txt_bake_GasFlow.Multiline = True
        Me.txt_bake_GasFlow.Name = "txt_bake_GasFlow"
        Me.txt_bake_GasFlow.Size = New System.Drawing.Size(119, 22)
        Me.txt_bake_GasFlow.TabIndex = 143
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(341, 168)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(113, 12)
        Me.Label85.TabIndex = 142
        Me.Label85.Text = "5.气体流量 GasFlow"
        '
        'txt_bake_tempgruve
        '
        Me.txt_bake_tempgruve.Location = New System.Drawing.Point(485, 118)
        Me.txt_bake_tempgruve.Multiline = True
        Me.txt_bake_tempgruve.Name = "txt_bake_tempgruve"
        Me.txt_bake_tempgruve.Size = New System.Drawing.Size(119, 22)
        Me.txt_bake_tempgruve.TabIndex = 141
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(341, 121)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(125, 12)
        Me.Label97.TabIndex = 140
        Me.Label97.Text = "5.温度曲线 TempGurve"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(264, 242)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(29, 12)
        Me.Label82.TabIndex = 58
        Me.Label82.Text = "Hour"
        '
        'txt_bake_bakingtime
        '
        Me.txt_bake_bakingtime.Location = New System.Drawing.Point(174, 239)
        Me.txt_bake_bakingtime.Multiline = True
        Me.txt_bake_bakingtime.Name = "txt_bake_bakingtime"
        Me.txt_bake_bakingtime.Size = New System.Drawing.Size(84, 22)
        Me.txt_bake_bakingtime.TabIndex = 57
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(52, 242)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(101, 12)
        Me.Label83.TabIndex = 56
        Me.Label83.Text = "4. 烘烤时效 Time"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(264, 200)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(29, 12)
        Me.Label66.TabIndex = 55
        Me.Label66.Text = "Hour"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(50, 291)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(65, 12)
        Me.Label46.TabIndex = 54
        Me.Label46.Text = "4.  Remark"
        '
        'txt_bake_baketime
        '
        Me.txt_bake_baketime.Location = New System.Drawing.Point(174, 197)
        Me.txt_bake_baketime.Multiline = True
        Me.txt_bake_baketime.Name = "txt_bake_baketime"
        Me.txt_bake_baketime.Size = New System.Drawing.Size(84, 22)
        Me.txt_bake_baketime.TabIndex = 53
        '
        'combo_bake_recipe
        '
        Me.combo_bake_recipe.FormattingEnabled = True
        Me.combo_bake_recipe.Location = New System.Drawing.Point(174, 115)
        Me.combo_bake_recipe.Name = "combo_bake_recipe"
        Me.combo_bake_recipe.Size = New System.Drawing.Size(84, 20)
        Me.combo_bake_recipe.TabIndex = 52
        '
        'btn_bake_exit
        '
        Me.btn_bake_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_bake_exit.Location = New System.Drawing.Point(497, 500)
        Me.btn_bake_exit.Name = "btn_bake_exit"
        Me.btn_bake_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_bake_exit.TabIndex = 49
        Me.btn_bake_exit.UseVisualStyleBackColor = True
        '
        'btn_bake_confirm
        '
        Me.btn_bake_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_bake_confirm.Location = New System.Drawing.Point(121, 500)
        Me.btn_bake_confirm.Name = "btn_bake_confirm"
        Me.btn_bake_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_bake_confirm.TabIndex = 48
        Me.btn_bake_confirm.UseVisualStyleBackColor = True
        '
        'txt_BAKE_lot
        '
        Me.txt_BAKE_lot.Location = New System.Drawing.Point(601, 33)
        Me.txt_BAKE_lot.Multiline = True
        Me.txt_BAKE_lot.Name = "txt_BAKE_lot"
        Me.txt_BAKE_lot.ReadOnly = True
        Me.txt_BAKE_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_BAKE_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_BAKE_lot.TabIndex = 47
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(557, 38)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(35, 12)
        Me.Label39.TabIndex = 46
        Me.Label39.Text = "LOT :"
        '
        'combo_BAKE_type
        '
        Me.combo_BAKE_type.FormattingEnabled = True
        Me.combo_BAKE_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_BAKE_type.Location = New System.Drawing.Point(145, 65)
        Me.combo_BAKE_type.Name = "combo_BAKE_type"
        Me.combo_BAKE_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_BAKE_type.TabIndex = 45
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(52, 65)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(77, 12)
        Me.Label40.TabIndex = 44
        Me.Label40.Text = "Recipe Type:"
        '
        'txt_BAKE_id
        '
        Me.txt_BAKE_id.ForeColor = System.Drawing.Color.Red
        Me.txt_BAKE_id.Location = New System.Drawing.Point(145, 33)
        Me.txt_BAKE_id.Name = "txt_BAKE_id"
        Me.txt_BAKE_id.ReadOnly = True
        Me.txt_BAKE_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_BAKE_id.TabIndex = 43
        Me.txt_BAKE_id.Text = "R"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(64, 38)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 12)
        Me.Label41.TabIndex = 42
        Me.Label41.Text = "Recipe ID:"
        '
        'txt_bake_remark
        '
        Me.txt_bake_remark.Location = New System.Drawing.Point(52, 329)
        Me.txt_bake_remark.Multiline = True
        Me.txt_bake_remark.Name = "txt_bake_remark"
        Me.txt_bake_remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_bake_remark.Size = New System.Drawing.Size(716, 82)
        Me.txt_bake_remark.TabIndex = 41
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(52, 200)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(101, 12)
        Me.Label42.TabIndex = 40
        Me.Label42.Text = "3. 烘烤时间 Time"
        '
        'txt_bake_temp
        '
        Me.txt_bake_temp.Location = New System.Drawing.Point(174, 156)
        Me.txt_bake_temp.Multiline = True
        Me.txt_bake_temp.Name = "txt_bake_temp"
        Me.txt_bake_temp.Size = New System.Drawing.Size(84, 24)
        Me.txt_bake_temp.TabIndex = 39
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(52, 159)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(101, 12)
        Me.Label43.TabIndex = 38
        Me.Label43.Text = "2. 烘烤温度 Temp"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(50, 118)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(107, 12)
        Me.Label44.TabIndex = 37
        Me.Label44.Text = "1.烘烤程序 Recipe"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.combo_BAKE_query)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_Query)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_delete)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_disable)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_copy)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_modify)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_new)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox9.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox9.TabIndex = 20
        Me.GroupBox9.TabStop = False
        '
        'combo_BAKE_query
        '
        Me.combo_BAKE_query.FormattingEnabled = True
        Me.combo_BAKE_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_BAKE_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_BAKE_query.Name = "combo_BAKE_query"
        Me.combo_BAKE_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_BAKE_query.TabIndex = 6
        Me.combo_BAKE_query.Text = "ENABLE"
        '
        'btn_BAKE_Query
        '
        Me.btn_BAKE_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_BAKE_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_BAKE_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_BAKE_Query.Name = "btn_BAKE_Query"
        Me.btn_BAKE_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_Query.TabIndex = 5
        Me.btn_BAKE_Query.UseVisualStyleBackColor = False
        '
        'btn_BAKE_delete
        '
        Me.btn_BAKE_delete.BackColor = System.Drawing.Color.Red
        Me.btn_BAKE_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_BAKE_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_BAKE_delete.Name = "btn_BAKE_delete"
        Me.btn_BAKE_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_delete.TabIndex = 4
        Me.btn_BAKE_delete.UseVisualStyleBackColor = False
        Me.btn_BAKE_delete.Visible = False
        '
        'btn_BAKE_disable
        '
        Me.btn_BAKE_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_BAKE_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_BAKE_disable.Name = "btn_BAKE_disable"
        Me.btn_BAKE_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_disable.TabIndex = 3
        Me.btn_BAKE_disable.UseVisualStyleBackColor = False
        '
        'btn_BAKE_copy
        '
        Me.btn_BAKE_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_BAKE_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_BAKE_copy.Name = "btn_BAKE_copy"
        Me.btn_BAKE_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_copy.TabIndex = 2
        Me.btn_BAKE_copy.UseVisualStyleBackColor = False
        '
        'btn_BAKE_modify
        '
        Me.btn_BAKE_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_BAKE_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_BAKE_modify.Name = "btn_BAKE_modify"
        Me.btn_BAKE_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_modify.TabIndex = 1
        Me.btn_BAKE_modify.UseVisualStyleBackColor = False
        '
        'btn_BAKE_new
        '
        Me.btn_BAKE_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_BAKE_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_BAKE_new.Name = "btn_BAKE_new"
        Me.btn_BAKE_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_new.TabIndex = 0
        Me.btn_BAKE_new.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DGV_BAKE)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        '
        'DGV_BAKE
        '
        Me.DGV_BAKE.AllowUserToAddRows = False
        Me.DGV_BAKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BAKE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_BAKE.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_BAKE.Location = New System.Drawing.Point(3, 17)
        Me.DGV_BAKE.Name = "DGV_BAKE"
        Me.DGV_BAKE.ReadOnly = True
        Me.DGV_BAKE.RowHeadersVisible = False
        Me.DGV_BAKE.RowTemplate.Height = 23
        Me.DGV_BAKE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_BAKE.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_BAKE.TabIndex = 0
        '
        'FTn
        '
        Me.FTn.BackColor = System.Drawing.Color.Transparent
        Me.FTn.Controls.Add(Me.grp_CP_para)
        Me.FTn.Controls.Add(Me.GroupBox5)
        Me.FTn.Controls.Add(Me.GroupBox4)
        Me.FTn.Location = New System.Drawing.Point(4, 24)
        Me.FTn.Name = "FTn"
        Me.FTn.Padding = New System.Windows.Forms.Padding(3)
        Me.FTn.Size = New System.Drawing.Size(1215, 932)
        Me.FTn.TabIndex = 1
        Me.FTn.Text = "FTn"
        '
        'grp_CP_para
        '
        Me.grp_CP_para.Controls.Add(Me.Panel3)
        Me.grp_CP_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_CP_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_CP_para.Name = "grp_CP_para"
        Me.grp_CP_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_CP_para.TabIndex = 21
        Me.grp_CP_para.TabStop = False
        Me.grp_CP_para.Text = "Parameters"
        Me.grp_CP_para.Visible = False
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.txt_FT_TestTime)
        Me.Panel3.Controls.Add(Me.Label71)
        Me.Panel3.Controls.Add(Me.Combo_ft_FIX3)
        Me.Panel3.Controls.Add(Me.Combo_ft_FIX2)
        Me.Panel3.Controls.Add(Me.Combo_ft_FIX1)
        Me.Panel3.Controls.Add(Me.Combo_ft_auto3)
        Me.Panel3.Controls.Add(Me.Combo_ft_auto2)
        Me.Panel3.Controls.Add(Me.Combo_ft_auto1)
        Me.Panel3.Controls.Add(Me.ChkB6_FT)
        Me.Panel3.Controls.Add(Me.ChkB5_FT)
        Me.Panel3.Controls.Add(Me.ChkB4_FT)
        Me.Panel3.Controls.Add(Me.ChkB3_FT)
        Me.Panel3.Controls.Add(Me.ChkB2_FT)
        Me.Panel3.Controls.Add(Me.ChkB1_FT)
        Me.Panel3.Controls.Add(Me.Label70)
        Me.Panel3.Controls.Add(Me.Label69)
        Me.Panel3.Controls.Add(Me.Label67)
        Me.Panel3.Controls.Add(Me.Label38)
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Controls.Add(Me.Label35)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.txt_FTn_remark)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.txt_FTn_attention)
        Me.Panel3.Controls.Add(Me.Label32)
        Me.Panel3.Controls.Add(Me.txt_FT_OtherSBL)
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Controls.Add(Me.txt_FT_HighYieldLimit)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.txt_FT_OsLimit)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.txt_FT_YieldLimit)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.txt_FT_LoadBoard)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.txt_FT_SOAKTIME)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.txt_FT_TestTemp)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.txt_FT_SWRev)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.txt_FT_Os)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.txt_FT_TestMode)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.txt_FT_SetupFile)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.txt_FT_Handler)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.txt_FT_TestFlatform)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.combo_ft_STAGE)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.btn_cp_exit)
        Me.Panel3.Controls.Add(Me.btn_cp_confirm)
        Me.Panel3.Controls.Add(Me.txt_ftn_lot)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.combo_ft_type)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txt_ft_id)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1203, 636)
        Me.Panel3.TabIndex = 79
        '
        'txt_FT_TestTime
        '
        Me.txt_FT_TestTime.Location = New System.Drawing.Point(757, 154)
        Me.txt_FT_TestTime.Name = "txt_FT_TestTime"
        Me.txt_FT_TestTime.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_TestTime.TabIndex = 196
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(673, 159)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(59, 12)
        Me.Label71.TabIndex = 195
        Me.Label71.Text = "TestTime:"
        '
        'Combo_ft_FIX3
        '
        Me.Combo_ft_FIX3.FormattingEnabled = True
        Me.Combo_ft_FIX3.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_ft_FIX3.Location = New System.Drawing.Point(421, 242)
        Me.Combo_ft_FIX3.Name = "Combo_ft_FIX3"
        Me.Combo_ft_FIX3.Size = New System.Drawing.Size(121, 20)
        Me.Combo_ft_FIX3.TabIndex = 194
        '
        'Combo_ft_FIX2
        '
        Me.Combo_ft_FIX2.FormattingEnabled = True
        Me.Combo_ft_FIX2.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_ft_FIX2.Location = New System.Drawing.Point(421, 206)
        Me.Combo_ft_FIX2.Name = "Combo_ft_FIX2"
        Me.Combo_ft_FIX2.Size = New System.Drawing.Size(121, 20)
        Me.Combo_ft_FIX2.TabIndex = 193
        '
        'Combo_ft_FIX1
        '
        Me.Combo_ft_FIX1.FormattingEnabled = True
        Me.Combo_ft_FIX1.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_ft_FIX1.Location = New System.Drawing.Point(421, 165)
        Me.Combo_ft_FIX1.Name = "Combo_ft_FIX1"
        Me.Combo_ft_FIX1.Size = New System.Drawing.Size(121, 20)
        Me.Combo_ft_FIX1.TabIndex = 192
        '
        'Combo_ft_auto3
        '
        Me.Combo_ft_auto3.FormattingEnabled = True
        Me.Combo_ft_auto3.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_ft_auto3.Location = New System.Drawing.Point(421, 127)
        Me.Combo_ft_auto3.Name = "Combo_ft_auto3"
        Me.Combo_ft_auto3.Size = New System.Drawing.Size(121, 20)
        Me.Combo_ft_auto3.TabIndex = 191
        '
        'Combo_ft_auto2
        '
        Me.Combo_ft_auto2.FormattingEnabled = True
        Me.Combo_ft_auto2.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_ft_auto2.Location = New System.Drawing.Point(421, 91)
        Me.Combo_ft_auto2.Name = "Combo_ft_auto2"
        Me.Combo_ft_auto2.Size = New System.Drawing.Size(121, 20)
        Me.Combo_ft_auto2.TabIndex = 190
        '
        'Combo_ft_auto1
        '
        Me.Combo_ft_auto1.FormattingEnabled = True
        Me.Combo_ft_auto1.Items.AddRange(New Object() {"BIN1", "BIN2", "BIN3", "BIN4", "BIN5", "BIN6"})
        Me.Combo_ft_auto1.Location = New System.Drawing.Point(423, 49)
        Me.Combo_ft_auto1.Name = "Combo_ft_auto1"
        Me.Combo_ft_auto1.Size = New System.Drawing.Size(121, 20)
        Me.Combo_ft_auto1.TabIndex = 189
        '
        'ChkB6_FT
        '
        Me.ChkB6_FT.AutoSize = True
        Me.ChkB6_FT.Location = New System.Drawing.Point(577, 252)
        Me.ChkB6_FT.Name = "ChkB6_FT"
        Me.ChkB6_FT.Size = New System.Drawing.Size(54, 16)
        Me.ChkB6_FT.TabIndex = 188
        Me.ChkB6_FT.Text = "Error"
        Me.ChkB6_FT.UseVisualStyleBackColor = True
        '
        'ChkB5_FT
        '
        Me.ChkB5_FT.AutoSize = True
        Me.ChkB5_FT.Location = New System.Drawing.Point(577, 214)
        Me.ChkB5_FT.Name = "ChkB5_FT"
        Me.ChkB5_FT.Size = New System.Drawing.Size(54, 16)
        Me.ChkB5_FT.TabIndex = 187
        Me.ChkB5_FT.Text = "Error"
        Me.ChkB5_FT.UseVisualStyleBackColor = True
        '
        'ChkB4_FT
        '
        Me.ChkB4_FT.AutoSize = True
        Me.ChkB4_FT.Location = New System.Drawing.Point(577, 175)
        Me.ChkB4_FT.Name = "ChkB4_FT"
        Me.ChkB4_FT.Size = New System.Drawing.Size(54, 16)
        Me.ChkB4_FT.TabIndex = 186
        Me.ChkB4_FT.Text = "Error"
        Me.ChkB4_FT.UseVisualStyleBackColor = True
        '
        'ChkB3_FT
        '
        Me.ChkB3_FT.AutoSize = True
        Me.ChkB3_FT.Location = New System.Drawing.Point(577, 134)
        Me.ChkB3_FT.Name = "ChkB3_FT"
        Me.ChkB3_FT.Size = New System.Drawing.Size(54, 16)
        Me.ChkB3_FT.TabIndex = 185
        Me.ChkB3_FT.Text = "Error"
        Me.ChkB3_FT.UseVisualStyleBackColor = True
        '
        'ChkB2_FT
        '
        Me.ChkB2_FT.AutoSize = True
        Me.ChkB2_FT.Location = New System.Drawing.Point(577, 94)
        Me.ChkB2_FT.Name = "ChkB2_FT"
        Me.ChkB2_FT.Size = New System.Drawing.Size(54, 16)
        Me.ChkB2_FT.TabIndex = 184
        Me.ChkB2_FT.Text = "Error"
        Me.ChkB2_FT.UseVisualStyleBackColor = True
        '
        'ChkB1_FT
        '
        Me.ChkB1_FT.AutoSize = True
        Me.ChkB1_FT.Location = New System.Drawing.Point(577, 56)
        Me.ChkB1_FT.Name = "ChkB1_FT"
        Me.ChkB1_FT.Size = New System.Drawing.Size(54, 16)
        Me.ChkB1_FT.TabIndex = 183
        Me.ChkB1_FT.Text = "Error"
        Me.ChkB1_FT.UseVisualStyleBackColor = True
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(931, 16)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(53, 12)
        Me.Label70.TabIndex = 182
        Me.Label70.Text = "关卡标准"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(673, 16)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(53, 12)
        Me.Label69.TabIndex = 181
        Me.Label69.Text = "作业条件"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(376, 245)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(35, 12)
        Me.Label67.TabIndex = 179
        Me.Label67.Text = "FIX3:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(376, 209)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(35, 12)
        Me.Label38.TabIndex = 177
        Me.Label38.Text = "FIX2:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(376, 170)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(35, 12)
        Me.Label34.TabIndex = 175
        Me.Label34.Text = "FIX1:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(376, 129)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(41, 12)
        Me.Label35.TabIndex = 173
        Me.Label35.Text = "AUTO3:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(374, 90)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(41, 12)
        Me.Label36.TabIndex = 171
        Me.Label36.Text = "AUTO2:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(376, 51)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(41, 12)
        Me.Label37.TabIndex = 169
        Me.Label37.Text = "AUTO1:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(376, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 12)
        Me.Label33.TabIndex = 168
        Me.Label33.Text = "托盘位置"
        '
        'txt_FTn_remark
        '
        Me.txt_FTn_remark.Location = New System.Drawing.Point(55, 508)
        Me.txt_FTn_remark.Multiline = True
        Me.txt_FTn_remark.Name = "txt_FTn_remark"
        Me.txt_FTn_remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FTn_remark.Size = New System.Drawing.Size(716, 82)
        Me.txt_FTn_remark.TabIndex = 167
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(51, 484)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 12)
        Me.Label31.TabIndex = 166
        Me.Label31.Text = "2. Remark"
        '
        'txt_FTn_attention
        '
        Me.txt_FTn_attention.Location = New System.Drawing.Point(53, 368)
        Me.txt_FTn_attention.Multiline = True
        Me.txt_FTn_attention.Name = "txt_FTn_attention"
        Me.txt_FTn_attention.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FTn_attention.Size = New System.Drawing.Size(716, 82)
        Me.txt_FTn_attention.TabIndex = 165
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(51, 344)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(71, 12)
        Me.Label32.TabIndex = 164
        Me.Label32.Text = "1. 注意事项"
        '
        'txt_FT_OtherSBL
        '
        Me.txt_FT_OtherSBL.Location = New System.Drawing.Point(1036, 165)
        Me.txt_FT_OtherSBL.Name = "txt_FT_OtherSBL"
        Me.txt_FT_OtherSBL.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_OtherSBL.TabIndex = 163
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(925, 168)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 12)
        Me.Label30.TabIndex = 162
        Me.Label30.Text = "OtherSBL(%):"
        '
        'txt_FT_HighYieldLimit
        '
        Me.txt_FT_HighYieldLimit.Location = New System.Drawing.Point(1037, 130)
        Me.txt_FT_HighYieldLimit.Name = "txt_FT_HighYieldLimit"
        Me.txt_FT_HighYieldLimit.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_HighYieldLimit.TabIndex = 161
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(926, 133)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(113, 12)
        Me.Label29.TabIndex = 160
        Me.Label29.Text = "HighYieldLimit(%):"
        '
        'txt_FT_OsLimit
        '
        Me.txt_FT_OsLimit.Location = New System.Drawing.Point(1037, 90)
        Me.txt_FT_OsLimit.Name = "txt_FT_OsLimit"
        Me.txt_FT_OsLimit.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_OsLimit.TabIndex = 159
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(926, 97)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 12)
        Me.Label28.TabIndex = 158
        Me.Label28.Text = "OSLimit(%):"
        '
        'txt_FT_YieldLimit
        '
        Me.txt_FT_YieldLimit.Location = New System.Drawing.Point(1037, 51)
        Me.txt_FT_YieldLimit.Name = "txt_FT_YieldLimit"
        Me.txt_FT_YieldLimit.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_YieldLimit.TabIndex = 157
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(926, 54)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 12)
        Me.Label27.TabIndex = 156
        Me.Label27.Text = "YieldLimit(%):"
        '
        'txt_FT_LoadBoard
        '
        Me.txt_FT_LoadBoard.Location = New System.Drawing.Point(758, 289)
        Me.txt_FT_LoadBoard.Name = "txt_FT_LoadBoard"
        Me.txt_FT_LoadBoard.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_LoadBoard.TabIndex = 155
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(671, 292)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 12)
        Me.Label26.TabIndex = 154
        Me.Label26.Text = "LoadBoard:"
        '
        'txt_FT_SOAKTIME
        '
        Me.txt_FT_SOAKTIME.Location = New System.Drawing.Point(757, 262)
        Me.txt_FT_SOAKTIME.Name = "txt_FT_SOAKTIME"
        Me.txt_FT_SOAKTIME.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_SOAKTIME.TabIndex = 153
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(670, 265)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 12)
        Me.Label25.TabIndex = 152
        Me.Label25.Text = "SoakTime:"
        '
        'txt_FT_TestTemp
        '
        Me.txt_FT_TestTemp.Location = New System.Drawing.Point(757, 235)
        Me.txt_FT_TestTemp.Name = "txt_FT_TestTemp"
        Me.txt_FT_TestTemp.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_TestTemp.TabIndex = 151
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(672, 238)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 12)
        Me.Label24.TabIndex = 150
        Me.Label24.Text = "TestTemp(℃):"
        '
        'txt_FT_SWRev
        '
        Me.txt_FT_SWRev.Location = New System.Drawing.Point(757, 208)
        Me.txt_FT_SWRev.Name = "txt_FT_SWRev"
        Me.txt_FT_SWRev.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_SWRev.TabIndex = 149
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(672, 211)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 12)
        Me.Label23.TabIndex = 148
        Me.Label23.Text = "S.W Rev:"
        '
        'txt_FT_Os
        '
        Me.txt_FT_Os.Location = New System.Drawing.Point(757, 181)
        Me.txt_FT_Os.Name = "txt_FT_Os"
        Me.txt_FT_Os.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_Os.TabIndex = 147
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(673, 186)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(23, 12)
        Me.Label22.TabIndex = 146
        Me.Label22.Text = "OS:"
        '
        'txt_FT_TestMode
        '
        Me.txt_FT_TestMode.Location = New System.Drawing.Point(757, 126)
        Me.txt_FT_TestMode.Name = "txt_FT_TestMode"
        Me.txt_FT_TestMode.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_TestMode.TabIndex = 145
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(672, 129)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 12)
        Me.Label21.TabIndex = 144
        Me.Label21.Text = "Test Mode:"
        '
        'txt_FT_SetupFile
        '
        Me.txt_FT_SetupFile.Location = New System.Drawing.Point(757, 99)
        Me.txt_FT_SetupFile.Name = "txt_FT_SetupFile"
        Me.txt_FT_SetupFile.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_SetupFile.TabIndex = 143
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(672, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 12)
        Me.Label20.TabIndex = 142
        Me.Label20.Text = "SetupFile:"
        '
        'txt_FT_Handler
        '
        Me.txt_FT_Handler.Location = New System.Drawing.Point(758, 72)
        Me.txt_FT_Handler.Name = "txt_FT_Handler"
        Me.txt_FT_Handler.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_Handler.TabIndex = 141
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(674, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 12)
        Me.Label18.TabIndex = 140
        Me.Label18.Text = "Handler:"
        '
        'txt_FT_TestFlatform
        '
        Me.txt_FT_TestFlatform.Location = New System.Drawing.Point(758, 45)
        Me.txt_FT_TestFlatform.Name = "txt_FT_TestFlatform"
        Me.txt_FT_TestFlatform.Size = New System.Drawing.Size(134, 21)
        Me.txt_FT_TestFlatform.TabIndex = 139
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(673, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 12)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "TestPlatform:"
        '
        'combo_ft_STAGE
        '
        Me.combo_ft_STAGE.FormattingEnabled = True
        Me.combo_ft_STAGE.Location = New System.Drawing.Point(137, 91)
        Me.combo_ft_STAGE.Name = "combo_ft_STAGE"
        Me.combo_ft_STAGE.Size = New System.Drawing.Size(134, 20)
        Me.combo_ft_STAGE.TabIndex = 88
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(51, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 12)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Stage :"
        '
        'btn_cp_exit
        '
        Me.btn_cp_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_cp_exit.Location = New System.Drawing.Point(593, 593)
        Me.btn_cp_exit.Name = "btn_cp_exit"
        Me.btn_cp_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_cp_exit.TabIndex = 86
        Me.btn_cp_exit.UseVisualStyleBackColor = True
        '
        'btn_cp_confirm
        '
        Me.btn_cp_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_cp_confirm.Location = New System.Drawing.Point(282, 593)
        Me.btn_cp_confirm.Name = "btn_cp_confirm"
        Me.btn_cp_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_cp_confirm.TabIndex = 85
        Me.btn_cp_confirm.UseVisualStyleBackColor = True
        '
        'txt_ftn_lot
        '
        Me.txt_ftn_lot.Location = New System.Drawing.Point(137, 181)
        Me.txt_ftn_lot.Multiline = True
        Me.txt_ftn_lot.Name = "txt_ftn_lot"
        Me.txt_ftn_lot.ReadOnly = True
        Me.txt_ftn_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_ftn_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_ftn_lot.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "LOT :"
        '
        'combo_ft_type
        '
        Me.combo_ft_type.FormattingEnabled = True
        Me.combo_ft_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_ft_type.Location = New System.Drawing.Point(137, 133)
        Me.combo_ft_type.Name = "combo_ft_type"
        Me.combo_ft_type.Size = New System.Drawing.Size(134, 20)
        Me.combo_ft_type.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Type:"
        '
        'txt_ft_id
        '
        Me.txt_ft_id.ForeColor = System.Drawing.Color.Red
        Me.txt_ft_id.Location = New System.Drawing.Point(137, 45)
        Me.txt_ft_id.Name = "txt_ft_id"
        Me.txt_ft_id.ReadOnly = True
        Me.txt_ft_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_ft_id.TabIndex = 80
        Me.txt_ft_id.Text = "R"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Recipe ID:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.combo_ft_stagequery)
        Me.GroupBox5.Controls.Add(Me.combo_ft_enable)
        Me.GroupBox5.Controls.Add(Me.btn_ft_Query)
        Me.GroupBox5.Controls.Add(Me.btn_ft_delete)
        Me.GroupBox5.Controls.Add(Me.btn_ft_disable)
        Me.GroupBox5.Controls.Add(Me.btn_ft_copy)
        Me.GroupBox5.Controls.Add(Me.btn_ft_modify)
        Me.GroupBox5.Controls.Add(Me.btn_ft_new)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        '
        'combo_ft_stagequery
        '
        Me.combo_ft_stagequery.FormattingEnabled = True
        Me.combo_ft_stagequery.Location = New System.Drawing.Point(122, 32)
        Me.combo_ft_stagequery.Name = "combo_ft_stagequery"
        Me.combo_ft_stagequery.Size = New System.Drawing.Size(80, 20)
        Me.combo_ft_stagequery.TabIndex = 7
        Me.combo_ft_stagequery.Text = "ALL"
        '
        'combo_ft_enable
        '
        Me.combo_ft_enable.FormattingEnabled = True
        Me.combo_ft_enable.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_ft_enable.Location = New System.Drawing.Point(20, 32)
        Me.combo_ft_enable.Name = "combo_ft_enable"
        Me.combo_ft_enable.Size = New System.Drawing.Size(80, 20)
        Me.combo_ft_enable.TabIndex = 6
        Me.combo_ft_enable.Text = "ENABLE"
        '
        'btn_ft_Query
        '
        Me.btn_ft_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ft_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_ft_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_ft_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_ft_Query.Name = "btn_ft_Query"
        Me.btn_ft_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_ft_Query.TabIndex = 5
        Me.btn_ft_Query.UseVisualStyleBackColor = False
        '
        'btn_ft_delete
        '
        Me.btn_ft_delete.BackColor = System.Drawing.Color.Red
        Me.btn_ft_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_ft_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_ft_delete.Name = "btn_ft_delete"
        Me.btn_ft_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_ft_delete.TabIndex = 4
        Me.btn_ft_delete.UseVisualStyleBackColor = False
        Me.btn_ft_delete.Visible = False
        '
        'btn_ft_disable
        '
        Me.btn_ft_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ft_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_ft_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_ft_disable.Name = "btn_ft_disable"
        Me.btn_ft_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_ft_disable.TabIndex = 3
        Me.btn_ft_disable.UseVisualStyleBackColor = False
        '
        'btn_ft_copy
        '
        Me.btn_ft_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ft_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_ft_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_ft_copy.Name = "btn_ft_copy"
        Me.btn_ft_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_ft_copy.TabIndex = 2
        Me.btn_ft_copy.UseVisualStyleBackColor = False
        '
        'btn_ft_modify
        '
        Me.btn_ft_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ft_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_ft_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_ft_modify.Name = "btn_ft_modify"
        Me.btn_ft_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_ft_modify.TabIndex = 1
        Me.btn_ft_modify.UseVisualStyleBackColor = False
        '
        'btn_ft_new
        '
        Me.btn_ft_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ft_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_ft_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_ft_new.Name = "btn_ft_new"
        Me.btn_ft_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_ft_new.TabIndex = 0
        Me.btn_ft_new.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGV_FT)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'DGV_FT
        '
        Me.DGV_FT.AllowUserToAddRows = False
        Me.DGV_FT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_FT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_FT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_FT.Location = New System.Drawing.Point(3, 17)
        Me.DGV_FT.Name = "DGV_FT"
        Me.DGV_FT.ReadOnly = True
        Me.DGV_FT.RowHeadersVisible = False
        Me.DGV_FT.RowTemplate.Height = 23
        Me.DGV_FT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_FT.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_FT.TabIndex = 0
        '
        'IQC
        '
        Me.IQC.BackColor = System.Drawing.Color.Transparent
        Me.IQC.Controls.Add(Me.grp_IQC_para)
        Me.IQC.Controls.Add(Me.GroupBox3)
        Me.IQC.Controls.Add(Me.GroupBox1)
        Me.IQC.Location = New System.Drawing.Point(4, 24)
        Me.IQC.Name = "IQC"
        Me.IQC.Padding = New System.Windows.Forms.Padding(3)
        Me.IQC.Size = New System.Drawing.Size(1215, 932)
        Me.IQC.TabIndex = 0
        Me.IQC.Text = "IQC"
        '
        'grp_IQC_para
        '
        Me.grp_IQC_para.Controls.Add(Me.Panel2)
        Me.grp_IQC_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_IQC_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_IQC_para.Name = "grp_IQC_para"
        Me.grp_IQC_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_IQC_para.TabIndex = 18
        Me.grp_IQC_para.TabStop = False
        Me.grp_IQC_para.Text = "Parameters"
        Me.grp_IQC_para.Visible = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.btn_IQC_cancel)
        Me.Panel2.Controls.Add(Me.btn_IQC_confirm)
        Me.Panel2.Controls.Add(Me.txt_IQC_lot)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.combo_IQC_type)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txt_IQC_id)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_IQC_Remark)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_IQC_SampleSize)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1203, 636)
        Me.Panel2.TabIndex = 29
        '
        'btn_IQC_cancel
        '
        Me.btn_IQC_cancel.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_IQC_cancel.Location = New System.Drawing.Point(494, 514)
        Me.btn_IQC_cancel.Name = "btn_IQC_cancel"
        Me.btn_IQC_cancel.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_cancel.TabIndex = 42
        Me.btn_IQC_cancel.UseVisualStyleBackColor = True
        '
        'btn_IQC_confirm
        '
        Me.btn_IQC_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_IQC_confirm.Location = New System.Drawing.Point(168, 514)
        Me.btn_IQC_confirm.Name = "btn_IQC_confirm"
        Me.btn_IQC_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_confirm.TabIndex = 41
        Me.btn_IQC_confirm.UseVisualStyleBackColor = True
        '
        'txt_IQC_lot
        '
        Me.txt_IQC_lot.Location = New System.Drawing.Point(427, 21)
        Me.txt_IQC_lot.Multiline = True
        Me.txt_IQC_lot.Name = "txt_IQC_lot"
        Me.txt_IQC_lot.ReadOnly = True
        Me.txt_IQC_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_IQC_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_IQC_lot.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(383, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 12)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "LOT :"
        '
        'combo_IQC_type
        '
        Me.combo_IQC_type.FormattingEnabled = True
        Me.combo_IQC_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_IQC_type.Location = New System.Drawing.Point(143, 55)
        Me.combo_IQC_type.Name = "combo_IQC_type"
        Me.combo_IQC_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_IQC_type.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 12)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Recipe Type:"
        '
        'txt_IQC_id
        '
        Me.txt_IQC_id.ForeColor = System.Drawing.Color.Red
        Me.txt_IQC_id.Location = New System.Drawing.Point(143, 23)
        Me.txt_IQC_id.Name = "txt_IQC_id"
        Me.txt_IQC_id.ReadOnly = True
        Me.txt_IQC_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_IQC_id.TabIndex = 36
        Me.txt_IQC_id.Text = "R"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Recipe ID:"
        '
        'txt_IQC_Remark
        '
        Me.txt_IQC_Remark.Location = New System.Drawing.Point(52, 272)
        Me.txt_IQC_Remark.Multiline = True
        Me.txt_IQC_Remark.Name = "txt_IQC_Remark"
        Me.txt_IQC_Remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_IQC_Remark.Size = New System.Drawing.Size(716, 82)
        Me.txt_IQC_Remark.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 12)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "2. Remark"
        '
        'txt_IQC_SampleSize
        '
        Me.txt_IQC_SampleSize.Location = New System.Drawing.Point(50, 132)
        Me.txt_IQC_SampleSize.Multiline = True
        Me.txt_IQC_SampleSize.Name = "txt_IQC_SampleSize"
        Me.txt_IQC_SampleSize.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_IQC_SampleSize.Size = New System.Drawing.Size(716, 82)
        Me.txt_IQC_SampleSize.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 12)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "1. IQC Sampling Size 抽样数量"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combo_IQC_query)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_Query)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_delete)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_disable)
        Me.GroupBox3.Controls.Add(Me.btn_iqc_copy)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_modify)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_new)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'combo_IQC_query
        '
        Me.combo_IQC_query.FormattingEnabled = True
        Me.combo_IQC_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_IQC_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_IQC_query.Name = "combo_IQC_query"
        Me.combo_IQC_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_IQC_query.TabIndex = 6
        Me.combo_IQC_query.Text = "ENABLE"
        '
        'btn_IQC_Query
        '
        Me.btn_IQC_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_IQC_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_IQC_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_IQC_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_IQC_Query.Name = "btn_IQC_Query"
        Me.btn_IQC_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_Query.TabIndex = 5
        Me.btn_IQC_Query.UseVisualStyleBackColor = False
        '
        'btn_IQC_delete
        '
        Me.btn_IQC_delete.BackColor = System.Drawing.Color.Red
        Me.btn_IQC_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_IQC_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_IQC_delete.Name = "btn_IQC_delete"
        Me.btn_IQC_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_delete.TabIndex = 4
        Me.btn_IQC_delete.UseVisualStyleBackColor = False
        Me.btn_IQC_delete.Visible = False
        '
        'btn_IQC_disable
        '
        Me.btn_IQC_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_IQC_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_IQC_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_IQC_disable.Name = "btn_IQC_disable"
        Me.btn_IQC_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_disable.TabIndex = 3
        Me.btn_IQC_disable.UseVisualStyleBackColor = False
        '
        'btn_iqc_copy
        '
        Me.btn_iqc_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_iqc_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_iqc_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_iqc_copy.Name = "btn_iqc_copy"
        Me.btn_iqc_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_iqc_copy.TabIndex = 2
        Me.btn_iqc_copy.UseVisualStyleBackColor = False
        '
        'btn_IQC_modify
        '
        Me.btn_IQC_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_IQC_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_IQC_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_IQC_modify.Name = "btn_IQC_modify"
        Me.btn_IQC_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_modify.TabIndex = 1
        Me.btn_IQC_modify.UseVisualStyleBackColor = False
        '
        'btn_IQC_new
        '
        Me.btn_IQC_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_IQC_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_IQC_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_IQC_new.Name = "btn_IQC_new"
        Me.btn_IQC_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_new.TabIndex = 0
        Me.btn_IQC_new.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_IQC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'DGV_IQC
        '
        Me.DGV_IQC.AllowUserToAddRows = False
        Me.DGV_IQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_IQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_IQC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_IQC.Location = New System.Drawing.Point(3, 17)
        Me.DGV_IQC.Name = "DGV_IQC"
        Me.DGV_IQC.ReadOnly = True
        Me.DGV_IQC.RowHeadersVisible = False
        Me.DGV_IQC.RowTemplate.Height = 23
        Me.DGV_IQC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_IQC.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_IQC.TabIndex = 0
        '
        'Tabcontrol
        '
        Me.Tabcontrol.Controls.Add(Me.IQC)
        Me.Tabcontrol.Controls.Add(Me.FTn)
        Me.Tabcontrol.Controls.Add(Me.BAKE)
        Me.Tabcontrol.Controls.Add(Me.QCn)
        Me.Tabcontrol.Controls.Add(Me.SCANVM)
        Me.Tabcontrol.Controls.Add(Me.FQC)
        Me.Tabcontrol.Controls.Add(Me.PACK)
        Me.Tabcontrol.Controls.Add(Me.SHIPOQC)
        Me.Tabcontrol.Controls.Add(Me.TR)
        Me.Tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabcontrol.ItemSize = New System.Drawing.Size(100, 20)
        Me.Tabcontrol.Location = New System.Drawing.Point(0, 0)
        Me.Tabcontrol.Multiline = True
        Me.Tabcontrol.Name = "Tabcontrol"
        Me.Tabcontrol.SelectedIndex = 0
        Me.Tabcontrol.Size = New System.Drawing.Size(1223, 960)
        Me.Tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.Tabcontrol.TabIndex = 7
        '
        'frmStepset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 960)
        Me.Controls.Add(Me.Tabcontrol)
        Me.Name = "frmStepset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StepDefineForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TR.ResumeLayout(False)
        Me.grp_tr_para.ResumeLayout(False)
        Me.grp_tr_para.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_TR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SHIPOQC.ResumeLayout(False)
        Me.grp_ship_para.ResumeLayout(False)
        Me.grp_ship_para.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        CType(Me.DGV_SHIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PACK.ResumeLayout(False)
        Me.grp_pack_para.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.DGV_PACK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FQC.ResumeLayout(False)
        Me.grp_FQC_para.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DGV_FQC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCANVM.ResumeLayout(False)
        Me.grp_wipfs_para.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DGV_scanvm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QCn.ResumeLayout(False)
        Me.grp_cpdt_para.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.DGV_QC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BAKE.ResumeLayout(False)
        Me.grp_bake_para.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DGV_BAKE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FTn.ResumeLayout(False)
        Me.grp_CP_para.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGV_FT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IQC.ResumeLayout(False)
        Me.grp_IQC_para.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_IQC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabcontrol.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TR As TabPage
    Friend WithEvents grp_tr_para As Panel
    Friend WithEvents txt_tr_yieldlimit As TextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents txt_tr_trjob As TextBox
    Friend WithEvents Label102 As Label
    Friend WithEvents btn_tr_exit As Button
    Friend WithEvents btn_tr_confirm As Button
    Friend WithEvents txt_tr_lot As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents combo_TR_type As ComboBox
    Friend WithEvents Label104 As Label
    Friend WithEvents txt_tr_id As TextBox
    Friend WithEvents Label105 As Label
    Friend WithEvents txt_tr_remark As TextBox
    Friend WithEvents Label106 As Label
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents combo_TR_query As ComboBox
    Friend WithEvents btn_TR_query As Button
    Friend WithEvents btn_TR_delete As Button
    Friend WithEvents btn_TR_disable As Button
    Friend WithEvents btn_TR_copy As Button
    Friend WithEvents btn_TR_MODIFY As Button
    Friend WithEvents btn_TR_NEW As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_TR As DataGridView
    Friend WithEvents SHIPOQC As TabPage
    Friend WithEvents grp_ship_para As GroupBox
    Friend WithEvents combo_ship_STAGE As ComboBox
    Friend WithEvents Label101 As Label
    Friend WithEvents btn_ship_exit As Button
    Friend WithEvents btn_ship_confirm As Button
    Friend WithEvents txt_ship_lot As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents combo_ship_type As ComboBox
    Friend WithEvents Label63 As Label
    Friend WithEvents txt_ship_id As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents txt_ship_REMARK As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents combo_SHIP_stagequery As ComboBox
    Friend WithEvents combo_ship_query As ComboBox
    Friend WithEvents btn_ship_query As Button
    Friend WithEvents btn_ship_delete As Button
    Friend WithEvents btn_ship_disable As Button
    Friend WithEvents btn_ship_copy As Button
    Friend WithEvents btn_ship_modify As Button
    Friend WithEvents btn_ship_new As Button
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents DGV_SHIP As DataGridView
    Friend WithEvents PACK As TabPage
    Friend WithEvents grp_pack_para As GroupBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_pack_packinfo As TextBox
    Friend WithEvents txt_pack_duetime As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents txt_pack_msl As TextBox
    Friend WithEvents Label98 As Label
    Friend WithEvents txt_pack_traystacking As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents txt_pack_packingjob As TextBox
    Friend WithEvents Label95 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents btn_pack_exit As Button
    Friend WithEvents btn_pack_confirm As Button
    Friend WithEvents txt_pack_lot As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents combo_pack_type As ComboBox
    Friend WithEvents Label59 As Label
    Friend WithEvents txt_pack_id As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents txt_pack_remark As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents combo_pack_query As ComboBox
    Friend WithEvents btn_pack_query As Button
    Friend WithEvents btn_pack_delete As Button
    Friend WithEvents btn_pack_disable As Button
    Friend WithEvents btn_pack_copy As Button
    Friend WithEvents btn_pack_modify As Button
    Friend WithEvents btn_pack_new As Button
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents DGV_PACK As DataGridView
    Friend WithEvents FQC As TabPage
    Friend WithEvents grp_FQC_para As GroupBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_FQC_traystacking As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_FQC_stage As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents txt_FQC_Remark As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btn_FQC_exit As Button
    Friend WithEvents btn_FQC_confirm As Button
    Friend WithEvents txt_FQC_lot As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents combo_FQC_type As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_FQC_ID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_FQC_Attention As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_FQC_SampleSize As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents combo_FQC_query As ComboBox
    Friend WithEvents btn_FQC_query As Button
    Friend WithEvents btn_FQC_delete As Button
    Friend WithEvents btn_FQC_disable As Button
    Friend WithEvents btn_FQC_copy As Button
    Friend WithEvents btn_FQC_modify As Button
    Friend WithEvents btn_FQC_new As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DGV_FQC As DataGridView
    Friend WithEvents SCANVM As TabPage
    Friend WithEvents grp_wipfs_para As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_scanvm_yieldlimit As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents txt_scanvm_traystacking As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents txt_scanvm_scanjob As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_scanvm_exit As Button
    Friend WithEvents btn_scanvm_confirm As Button
    Friend WithEvents txt_scanvm_lot As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents combo_scanvm_type As ComboBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txt_scanvm_id As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txt_scanvm_remark As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents combo_scanvm_query As ComboBox
    Friend WithEvents btn_scanvm_Query As Button
    Friend WithEvents btn_scanvm_delete As Button
    Friend WithEvents btn_scanvm_disable As Button
    Friend WithEvents btn_scanvm_copy As Button
    Friend WithEvents btn_scanvm_modify As Button
    Friend WithEvents btn_scanvm_new As Button
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents DGV_scanvm As DataGridView
    Friend WithEvents QCn As TabPage
    Friend WithEvents grp_cpdt_para As GroupBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_QC_samplingsize As TextBox
    Friend WithEvents Label96 As Label
    Friend WithEvents txt_QC_testtime As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents Combo_QC_FIX3 As ComboBox
    Friend WithEvents Combo_QC_FIX2 As ComboBox
    Friend WithEvents Combo_QC_FIX1 As ComboBox
    Friend WithEvents Combo_QC_AUTO3 As ComboBox
    Friend WithEvents Combo_QC_AUTO2 As ComboBox
    Friend WithEvents Combo_QC_AUTO1 As ComboBox
    Friend WithEvents ChkB6_QC As CheckBox
    Friend WithEvents ChkB5_QC As CheckBox
    Friend WithEvents ChkB4_QC As CheckBox
    Friend WithEvents ChkB3_QC As CheckBox
    Friend WithEvents ChkB2_QC As CheckBox
    Friend WithEvents ChkB1_QC As CheckBox
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents txt_QC_loadboard As TextBox
    Friend WithEvents Label86 As Label
    Friend WithEvents txt_QC_soaktime As TextBox
    Friend WithEvents Label87 As Label
    Friend WithEvents txt_QC_temp As TextBox
    Friend WithEvents Label88 As Label
    Friend WithEvents txt_QC_swrev As TextBox
    Friend WithEvents Label89 As Label
    Friend WithEvents txt_QC_os As TextBox
    Friend WithEvents Label90 As Label
    Friend WithEvents txt_QC_testmode As TextBox
    Friend WithEvents Label91 As Label
    Friend WithEvents txt_QC_setupfile As TextBox
    Friend WithEvents Label92 As Label
    Friend WithEvents txt_QC_Handler As TextBox
    Friend WithEvents Label93 As Label
    Friend WithEvents txt_QC_TestFlatform As TextBox
    Friend WithEvents Label94 As Label
    Friend WithEvents txt_QC_Remark As TextBox
    Friend WithEvents combo_QC_Stage As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents txt_QC_exit As Button
    Friend WithEvents txt_QC_confirm As Button
    Friend WithEvents txt_QC_lot As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents combo_QC_type As ComboBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txt_QC_id As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents txt_QC_Attention As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents combo_QC_stagequery As ComboBox
    Friend WithEvents combo_QC_enable As ComboBox
    Friend WithEvents btn_QC_Query As Button
    Friend WithEvents btn_QC_delete As Button
    Friend WithEvents btn_QC_disable As Button
    Friend WithEvents btn_QC_copy As Button
    Friend WithEvents btn_QC_modify As Button
    Friend WithEvents btn_QC_new As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents DGV_QC As DataGridView
    Friend WithEvents BAKE As TabPage
    Friend WithEvents grp_bake_para As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_bake_GasFlow As TextBox
    Friend WithEvents Label85 As Label
    Friend WithEvents txt_bake_tempgruve As TextBox
    Friend WithEvents Label97 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents txt_bake_bakingtime As TextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents txt_bake_baketime As TextBox
    Friend WithEvents combo_bake_recipe As ComboBox
    Friend WithEvents btn_bake_exit As Button
    Friend WithEvents btn_bake_confirm As Button
    Friend WithEvents txt_BAKE_lot As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents combo_BAKE_type As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txt_BAKE_id As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txt_bake_remark As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txt_bake_temp As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents combo_BAKE_query As ComboBox
    Friend WithEvents btn_BAKE_Query As Button
    Friend WithEvents btn_BAKE_delete As Button
    Friend WithEvents btn_BAKE_disable As Button
    Friend WithEvents btn_BAKE_copy As Button
    Friend WithEvents btn_BAKE_modify As Button
    Friend WithEvents btn_BAKE_new As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DGV_BAKE As DataGridView
    Friend WithEvents FTn As TabPage
    Friend WithEvents grp_CP_para As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_FT_TestTime As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents Combo_ft_FIX3 As ComboBox
    Friend WithEvents Combo_ft_FIX2 As ComboBox
    Friend WithEvents Combo_ft_FIX1 As ComboBox
    Friend WithEvents Combo_ft_auto3 As ComboBox
    Friend WithEvents Combo_ft_auto2 As ComboBox
    Friend WithEvents Combo_ft_auto1 As ComboBox
    Friend WithEvents ChkB6_FT As CheckBox
    Friend WithEvents ChkB5_FT As CheckBox
    Friend WithEvents ChkB4_FT As CheckBox
    Friend WithEvents ChkB3_FT As CheckBox
    Friend WithEvents ChkB2_FT As CheckBox
    Friend WithEvents ChkB1_FT As CheckBox
    Friend WithEvents Label70 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txt_FTn_remark As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_FTn_attention As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_FT_OtherSBL As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_FT_HighYieldLimit As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_FT_OsLimit As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txt_FT_YieldLimit As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_FT_LoadBoard As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_FT_SOAKTIME As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_FT_TestTemp As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_FT_SWRev As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_FT_Os As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_FT_TestMode As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_FT_SetupFile As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_FT_Handler As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_FT_TestFlatform As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents combo_ft_STAGE As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_cp_exit As Button
    Friend WithEvents btn_cp_confirm As Button
    Friend WithEvents txt_ftn_lot As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_ft_type As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ft_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents combo_ft_stagequery As ComboBox
    Friend WithEvents combo_ft_enable As ComboBox
    Friend WithEvents btn_ft_Query As Button
    Friend WithEvents btn_ft_delete As Button
    Friend WithEvents btn_ft_disable As Button
    Friend WithEvents btn_ft_copy As Button
    Friend WithEvents btn_ft_modify As Button
    Friend WithEvents btn_ft_new As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGV_FT As DataGridView
    Friend WithEvents IQC As TabPage
    Friend WithEvents grp_IQC_para As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_IQC_cancel As Button
    Friend WithEvents btn_IQC_confirm As Button
    Friend WithEvents txt_IQC_lot As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents combo_IQC_type As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_IQC_id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_IQC_Remark As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_IQC_SampleSize As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_IQC_query As ComboBox
    Friend WithEvents btn_IQC_Query As Button
    Friend WithEvents btn_IQC_delete As Button
    Friend WithEvents btn_IQC_disable As Button
    Friend WithEvents btn_iqc_copy As Button
    Friend WithEvents btn_IQC_modify As Button
    Friend WithEvents btn_IQC_new As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_IQC As DataGridView
    Friend WithEvents Tabcontrol As TabControl
End Class
