﻿using Com.Nidec.Mes.GlobalMasterMaintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework.Login;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance;

namespace Com.Nidec.Mes.VCMS
{
    public partial class FormMain : GlobalMasterMaintenance.FormCommonNCVP
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Main form loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            SystemMaster_gpb.Visible = false;
            NcvpMaster_gpb.Visible = false;
            NCVC_Function_gr.Visible = false;

            //if (UserData.GetUserData().UserCode == "admin")
            //{
            //    SystemMaster_btn.Enabled = false;
            //}
        }
        /// <summary>
        /// System Master Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemMaster_btn_Click(object sender, EventArgs e)
        {
            SystemMaster_gpb.Visible = true;
            NcvpMaster_gpb.Visible = false;
            NCVC_Function_gr.Visible = false;
        }
        /// <summary>
        /// Local Master Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NcvpMaster_btn_Click(object sender, EventArgs e)
        {
            NcvpMaster_gpb.Visible = true;
            SystemMaster_gpb.Visible = false;
            NCVC_Function_gr.Visible = false;
        }
        /// <summary>
        /// NCVP Function Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ncvp_btn_Click(object sender, EventArgs e)
        {
            NCVC_Function_gr.Visible = true;
            SystemMaster_gpb.Visible = false;
            NcvpMaster_gpb.Visible = false;
        }
        /// <summary>
        /// NCVC Function Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ncvc_btn_Click(object sender, EventArgs e)
        {
            NCVC_Function_gr.Visible = false;
            SystemMaster_gpb.Visible = false;
            NcvpMaster_gpb.Visible = false;
        }
        /// <summary>
        /// DownTime button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownTime_bt_Click(object sender, EventArgs e)
        {
            ReportDownTimeForm reportdowntimeform = new ReportDownTimeForm();
            reportdowntimeform.ShowDialog();
        }
        /// <summary>
        /// Jig Repair Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jig_repair_btn_Click(object sender, EventArgs e)
        {
            JigRepairInformationForm reportdowntimeform = new JigRepairInformationForm();
            reportdowntimeform.ShowDialog();
        }
        /// <summary>
        /// Register Drawing Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawRegist_btn_Click(object sender, EventArgs e)
        {
            DrawForm drawform = new DrawForm();
            drawform.Show();
        }
        /// <summary>
        /// Document Management Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Doc_Main_btn_Click(object sender, EventArgs e)
        {
            DocumentForm docfrm = new DocumentForm();
            docfrm.ShowDialog();
        }
        /// <summary>
        /// Warehouse Management Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// Change Password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePass_btn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpform = new ChangePasswordForm();
            cpform.ShowDialog();
        }
        #region System Master
        private void user_bt_Click(object sender, EventArgs e)
        {
            UserMasterForm usermasterform = new UserMasterForm();
            usermasterform.ShowDialog();
        }

        private void local_user_btn_Click(object sender, EventArgs e)
        {
            LocalUserMasterForm localuser = new LocalUserMasterForm();
            localuser.ShowDialog();
        }

        private void language_bt_Click(object sender, EventArgs e)
        {
            CountryLanguageForm conlang = new CountryLanguageForm();
            conlang.ShowDialog();
        }

        private void factory_bt_Click(object sender, EventArgs e)
        {
            FactoryMasterForm factory = new FactoryMasterForm();
            factory.ShowDialog();
        }

        private void userfac_bt_Click(object sender, EventArgs e)
        {
            UserFactoryForm userfact = new UserFactoryForm();
            userfact.ShowDialog();
        }

        private void auth_cotrol_bt_Click(object sender, EventArgs e)
        {
            AuthorityControlForm authorityctr = new AuthorityControlForm();
            authorityctr.ShowDialog();
        }

        private void Role_btn_Click(object sender, EventArgs e)
        {
            RoleForm roleform = new RoleForm();
            roleform.ShowDialog();
        }

        private void UserRoles_btn_Click(object sender, EventArgs e)
        {

            UserRoleForm userrole = new UserRoleForm();
            userrole.ShowDialog();
        }

        private void RoleAuthorityControl_btn_Click(object sender, EventArgs e)
        {
            RoleAuthorityControlForm roleauthor = new RoleAuthorityControlForm();
            roleauthor.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region NCVP Master
        private void Equipment_btn_Click(object sender, EventArgs e)
        {
            EquipmentForm equipmasterform = new EquipmentForm();
            equipmasterform.ShowDialog();
        }

        private void Process_btn_Click(object sender, EventArgs e)
        {
            ProcessForm processmasterform = new ProcessForm();
            processmasterform.ShowDialog();
        }

        private void Model_btn_Click(object sender, EventArgs e)
        {
            ModelMasterForm modelmasterform = new ModelMasterForm();
            modelmasterform.ShowDialog();
        }

        private void DefectiveReason_btn_Click(object sender, EventArgs e)
        {
            DefectiveReasonForm defectmasterform = new DefectiveReasonForm();
            defectmasterform.ShowDialog();
        }

        private void ProductionWorkContent_btn_Click(object sender, EventArgs e)
        {
            ProdutionWorkContentForm prodworkcontmasterform = new ProdutionWorkContentForm();
            prodworkcontmasterform.ShowDialog();
        }

        private void Line_btn_Click(object sender, EventArgs e)
        {
            LineMasterForm linemasterform = new LineMasterForm();
            linemasterform.ShowDialog();
        }

        private void Machine_btn_Click(object sender, EventArgs e)
        {
            MachineForm machinemasterform = new MachineForm();
            machinemasterform.ShowDialog();
        }

        private void modellinemaster_btn_Click(object sender, EventArgs e)
        {
            ModelLineMasterForm modelline = new ModelLineMasterForm();
            modelline.ShowDialog();
        }

        private void response_machine_btn_Click(object sender, EventArgs e)
        {
            ResponseMachineMasterForm respmachine = new ResponseMachineMasterForm();
            respmachine.ShowDialog();
        }

        private void JigCause_btn_Click(object sender, EventArgs e)
        {
            JigCauseMasterForm jigcause = new JigCauseMasterForm();
            jigcause.ShowDialog();
        }

        private void JigResponse_btn_Click(object sender, EventArgs e)
        {
            JigResponseMasterForm jigrespform = new JigResponseMasterForm();
            jigrespform.ShowDialog();
        }

        private void DefectiveCategory_btn_Click(object sender, EventArgs e)
        {
            DefectiveCategoryForm dcform = new DefectiveCategoryForm();
            dcform.ShowDialog();
        }

        private void ProductionWorkContType_btn_Click(object sender, EventArgs e)
        {
            ProdutionWorkContentTypeForm prodworkconttypeform = new ProdutionWorkContentTypeForm();
            prodworkconttypeform.ShowDialog();
        }

        private void ProcessModel_btn_Click(object sender, EventArgs e)
        {
            ModelProcessMasterForm modelprocess = new ModelProcessMasterForm();
            modelprocess.ShowDialog();
        }

        private void Draw_btn_Click(object sender, EventArgs e)
        {
            DrawMasterForm draw = new DrawMasterForm();
            draw.Show();
        }

        private void Supplier_btn_Click(object sender, EventArgs e)
        {
            LocalSupplierForm supplierform = new LocalSupplierForm();
            supplierform.ShowDialog();
        }

        private void equipment_machine_btn_Click(object sender, EventArgs e)
        {
            MachineAndEquipmentMaster mceqform = new MachineAndEquipmentMaster();
            mceqform.ShowDialog();
        }

        private void Location_btn_Click(object sender, EventArgs e)
        {
            LocationForm locaform = new LocationForm();
            locaform.ShowDialog();
        }

        private void Building_btn_Click(object sender, EventArgs e)
        {
            BuildingForm buildform = new BuildingForm();
            buildform.ShowDialog();
        }
        private void Asset_btn_Click(object sender, EventArgs e)
        {
            AssetForm asf = new AssetForm();
            asf.ShowDialog();
        }
        private void Rank_btn_Click(object sender, EventArgs e)
        {
            RankForm rkf = new RankForm();
            rkf.ShowDialog();
        }
        private void User_Localtion_btn_Click(object sender, EventArgs e)
        {
            UserLocationForm ulf = new UserLocationForm();
            ulf.ShowDialog();
        }
        #endregion

        private void MachineWorkingStatus_btn_Click(object sender, EventArgs e)
        {
            WorkingStatusForm workingstatusfrm = new WorkingStatusForm();
            workingstatusfrm.ShowDialog();
        }

        private void AddPlan_btn_Click(object sender, EventArgs e)
        {
            AddPlanWorkingStatusForm ad = new AddPlanWorkingStatusForm();
            ad.ShowDialog();
        }

        private void AddMachineStatus_btn_Click(object sender, EventArgs e)
        {
            AddMachineStatusForm ad = new AddMachineStatusForm();
            ad.ShowDialog();
        }

        private void AccountCode_btn_Click(object sender, EventArgs e)
        {
            AccountCodeForm acForm = new AccountCodeForm();
            acForm.ShowDialog();
        }

        private void AccountLocation_btn_Click(object sender, EventArgs e)
        {
            AccountLocationForm acForm = new AccountLocationForm();
            acForm.ShowDialog();
        }

        private void account_equipments_btn_Click(object sender, EventArgs e)
        {
            AccountMainForm accountForm = new AccountMainForm();
            accountForm.ShowDialog();
        }

        private void WarehouseManagement_New_frm_Click(object sender, EventArgs e)
        {
            WarehouseMainForm nwe = new WarehouseMainForm();
            nwe.ShowDialog();
        }

        private void DetailPosition_btn_Click(object sender, EventArgs e)
        {
            DetailPositionForm fdf = new DetailPositionForm();
            fdf.ShowDialog();
        }

        private void production_controller_btn_Click(object sender, EventArgs e)
        {
            //ProductionControllerForm fd = new ProductionControllerForm();
            ////fd.ShowDialog();
            ProductionControllerNCVCForm a = new ProductionControllerNCVCForm();
            a.ShowDialog();
        }

        private void Unit_btn_Click(object sender, EventArgs e)
        {
            UnitForm unitform = new UnitForm();
            unitform.ShowDialog();
        }

        private void ovenrange_btn_Click(object sender, EventArgs e)
        {
            RangeForm rangeform = new RangeForm();
            rangeform.ShowDialog();
        }

        private void ovenbarcode_btn_Click(object sender, EventArgs e)
        {
            OvenBarcodeForm ovenbarcodefrom = new OvenBarcodeForm();
            ovenbarcodefrom.ShowDialog();
        }

        private void CauseMC_btn_Click(object sender, EventArgs e)
        {
            CauseMasterForm cause = new CauseMasterForm();
            cause.ShowDialog();
        }

        private void ProcessW_btn_Click(object sender, EventArgs e)
        {
            ProcessWForm prw = new ProcessWForm();
            prw.ShowDialog();
        }
    }
}
