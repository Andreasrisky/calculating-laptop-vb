Public Class AA
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Buk As m
        Dim laptop As String
        laptop = ComboBox1.SelectedIndex
        Select Case laptop
            Case 0
                Buk.harddisk = "AMD PRO A6-7350B R5"
                Buk.ram = "4GB DDR4"
                Buk.mikroprosesor = "5 COMPUTES CORES 2C+3G 3,00GHz"
                Buk.harga = 4900000
            Case 1
                Buk.harddisk = "INTEL UHD"
                Buk.ram = "8GB DDR4"
                Buk.mikroprosesor = "SSD 128 GB SATA"
                Buk.harga = 6500000
            Case 2
                Buk.harddisk = "INTER CORE I3-1115GB"
                Buk.ram = "8GB DDR4"
                Buk.mikroprosesor = "512GB SSD"
                Buk.harga = 3000000
            Case 3
                Buk.harddisk = "INTEL CORE I5 "
                Buk.ram = "4GB"
                Buk.mikroprosesor = "320 GB HDD"
                Buk.harga = 4000000
        End Select
        TextBox1.Text = Buk.harddisk
        TextBox2.Text = Buk.ram
        TextBox3.Text = Buk.mikroprosesor
        TextBox4.Text = Buk.harga
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = TextBox5.Text * TextBox4.Text
    End Sub
End Class
