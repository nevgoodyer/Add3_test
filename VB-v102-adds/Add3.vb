Public Class Add3
	Private Number_1, Number_2, Number_3, total As Integer                   'declaration of variables
	Private Sub BtnCalcSum_Click(sender As Object, e As EventArgs) Handles BtnCalcSum.Click
		Number_1 = CInt(txtNumber_1.Text)              'read user inputs
		Number_2 = CInt(txtNumber_2.Text)
		Number_3 = CInt(txtNumber_3.Text)
		total = Number_1 + Number_2 + Number_3      'assignment step
		txtTotalSum.Text = total                    'display step
	End Sub
End Class
