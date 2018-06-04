Imports QLCC_BUS
Imports QLCC_DTO
Imports Utility
Imports System.Data.SqlClient

Public Class UCLichCS
    Private lichBus As LichChamSocBUS
    Private lichCTBus As LichChamSoc_CTBUS
    Dim connection As New SqlConnection("Data Source=DESKTOP-SNJJV8M;Initial Catalog=QLCC;Integrated Security=True")

    Private Sub UCLichCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lichBus = New LichChamSocBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = lichBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDLich.Text = nextID.ToString()
        End If
    End Sub

    Private Sub btn_ThemDV_Click(sender As Object, e As EventArgs) Handles btn_ThemDV.Click
        Dim lichCS As LichChamSocDTO
        lichCS = New LichChamSocDTO()

        Dim lichCSCT As LichChamSoc_CTDTO
        lichCSCT = New LichChamSoc_CTDTO()

        '1. Mapping data from GUI control
        lichCS.MS_LichCS = Convert.ToInt32(tbx_IDLich.Text)
        lichCS.TG_ChamSoc = dtp_TGLich.Value
        lichCSCT.MS_LichCS = Convert.ToInt32(tbx_IDLich.Text)
        lichCSCT.MS_LichCSCT = Convert.ToInt32(tbx_IDLichCT.Text)
        lichCSCT.MS_ChamSoc = Convert.ToInt32(tbx_IDLichCT.Text)

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = lichBus.insert(lichCS)
        Dim result_CT As Result
        result_CT = lichCTBus.insert(lichCSCT)
        If (result.FlagResult = True And result_CT.FlagResult = True) Then
            MessageBox.Show("Thêm lich cham soc thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Get Next ID
            Dim nextID As Integer
            result = lichBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                tbx_IDLich.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của lich cham soc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm lich cham soc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btn_next1_Click(sender As Object, e As EventArgs) Handles btn_next1.Click
        lichCTBus = New LichChamSoc_CTBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = lichCTBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            tbx_IDLichCT.Text = nextID.ToString()
        End If

        'connect table [CAY]

        Dim command_cay As New SqlCommand("SELECT * FROM [CAY]", connection)
        Dim adapter_cay As New SqlDataAdapter(command_cay)
        Dim table_cay As New DataTable()
        adapter_cay.Fill(table_cay)
        cbx_TenCay.DataSource = table_cay
        cbx_TenCay.DisplayMember = "TENCAY"
        cbx_TenCay.ValueMember = "ID_CAY"
    End Sub

    Private Sub btn_Next2_Click(sender As Object, e As EventArgs) Handles btn_Next2.Click
        'connect table [CHAMSOCCAY]

        Dim command_CScay As New SqlCommand("SELECT * FROM [CHAMSOC_CAY] WHERE [ID_CAY]= " + Convert.ToString(cbx_TenCay.ValueMember), connection)
        Dim adapter_CScay As New SqlDataAdapter(command_CScay)
        Dim table_CScay As New DataTable()
        adapter_CScay.Fill(table_CScay)
        cbx_TGchamOfcay.DataSource = table_CScay
        cbx_TGchamOfcay.DisplayMember = "TG_CHAMSOC"
        cbx_TGchamOfcay.ValueMember = "ID_CHAMSOC"
    End Sub
End Class
