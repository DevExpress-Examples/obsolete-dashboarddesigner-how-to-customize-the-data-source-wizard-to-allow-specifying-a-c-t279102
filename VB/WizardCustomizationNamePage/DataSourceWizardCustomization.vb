Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.DataSourceWizard
Imports DevExpress.DashboardWin.ServiceModel
Imports DevExpress.DataAccess.UI.Wizard
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.DataAccess.Wizard.Views
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WizardCustomizationExample
    Public Class DataSourceWizardCustomization
        Implements IDashboardDataSourceWizardCustomization

        Public Sub CustomizeDataSourceWizard(ByVal customization As IWizardCustomization(Of DashboardDataSourceModel)) Implements IDashboardDataSourceWizardCustomization.CustomizeDataSourceWizard
            customization.StartPage = GetType(CustomChooseDataSourceNamePage(Of DashboardDataSourceModel))
            customization.RegisterPage(Of CustomChooseDataSourceNamePage(Of DashboardDataSourceModel), CustomChooseDataSourceNamePage(Of DashboardDataSourceModel))()
        End Sub
    End Class
    Public Class CustomChooseDataSourceNamePage(Of TModel As IDataSourceModel)
        Inherits ChooseDataSourceNamePage(Of DashboardDataSourceModel)

        Public Sub New(ByVal view As IChooseDataSourceNamePageView, ByVal dataSourceNameCreator As IDataSourceNameCreationService)
            MyBase.New(view, dataSourceNameCreator)
        End Sub
        Public Overrides Function GetNextPageType() As Type
            Return GetType(DashboardChooseDataSourceTypePage(Of DashboardDataSourceModel))
        End Function
    End Class
End Namespace
