using DevExpress.DashboardCommon;
using DevExpress.DashboardCommon.DataSourceWizard;
using DevExpress.DashboardWin.ServiceModel;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.DataAccess.Wizard.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardCustomizationExample {
    public class DataSourceWizardCustomization : IDashboardDataSourceWizardCustomization {

        public void CustomizeDataSourceWizard(IWizardCustomization<DashboardDataSourceModel> customization) {
            customization.StartPage = typeof(CustomChooseDataSourceNamePage<DashboardDataSourceModel>);
            customization.RegisterPage<CustomChooseDataSourceNamePage<DashboardDataSourceModel>, CustomChooseDataSourceNamePage<DashboardDataSourceModel>>();
        }
    }
    public class CustomChooseDataSourceNamePage<TModel> : ChooseDataSourceNamePage<DashboardDataSourceModel> where TModel : IDataSourceModel {
        public CustomChooseDataSourceNamePage(IChooseDataSourceNamePageView view, IDataSourceNameCreationService dataSourceNameCreator)
            : base(view, dataSourceNameCreator) {
        }
        public override Type GetNextPageType() {
            return typeof(DashboardChooseDataSourceTypePage<DashboardDataSourceModel>);
        }
    }
}
