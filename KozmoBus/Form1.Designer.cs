namespace KozmoBus {
    partial class frmPadre {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPadre));
            this.ribPadre = new System.Windows.Forms.Ribbon();
            this.ribTabUsuarios = new System.Windows.Forms.RibbonTab();
            this.ribPanelUsuarios = new System.Windows.Forms.RibbonPanel();
            this.ribButtonAddUser = new System.Windows.Forms.RibbonButton();
            this.ribButtonDropUser = new System.Windows.Forms.RibbonButton();
            this.ribButtonEditUser = new System.Windows.Forms.RibbonButton();
            this.ribPanelPerfiles = new System.Windows.Forms.RibbonPanel();
            this.ribButtonAddProfile = new System.Windows.Forms.RibbonButton();
            this.ribButtonDropProfile = new System.Windows.Forms.RibbonButton();
            this.ribButtonEditProfile = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribPadre
            // 
            this.ribPadre.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ribPadre.Location = new System.Drawing.Point(0, 0);
            this.ribPadre.Minimized = false;
            this.ribPadre.Name = "ribPadre";
            // 
            // 
            // 
            this.ribPadre.OrbDropDown.BorderRoundness = 8;
            this.ribPadre.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribPadre.OrbDropDown.Name = "";
            this.ribPadre.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribPadre.OrbDropDown.TabIndex = 0;
            this.ribPadre.OrbImage = null;
            this.ribPadre.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribPadre.Size = new System.Drawing.Size(653, 129);
            this.ribPadre.TabIndex = 0;
            this.ribPadre.Tabs.Add(this.ribTabUsuarios);
            this.ribPadre.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribPadre.Text = "ribbon1";
            this.ribPadre.ThemeColor = System.Windows.Forms.RibbonTheme.JellyBelly;
            // 
            // ribTabUsuarios
            // 
            this.ribTabUsuarios.Panels.Add(this.ribPanelUsuarios);
            this.ribTabUsuarios.Panels.Add(this.ribPanelPerfiles);
            this.ribTabUsuarios.Text = "Permisos";
            // 
            // ribPanelUsuarios
            // 
            this.ribPanelUsuarios.ButtonMoreVisible = false;
            this.ribPanelUsuarios.Items.Add(this.ribButtonAddUser);
            this.ribPanelUsuarios.Items.Add(this.ribButtonDropUser);
            this.ribPanelUsuarios.Items.Add(this.ribButtonEditUser);
            this.ribPanelUsuarios.Text = "Usuarios";
            // 
            // ribButtonAddUser
            // 
            this.ribButtonAddUser.Image = global::KozmoBus.Properties.Resources.AddUser;
            this.ribButtonAddUser.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribButtonAddUser.SmallImage")));
            this.ribButtonAddUser.ToolTip = "Permite agregar un usuario al sistema.";
            this.ribButtonAddUser.ToolTipImage = global::KozmoBus.Properties.Resources.AddUser;
            this.ribButtonAddUser.ToolTipTitle = "Agregar un usuario";
            // 
            // ribButtonDropUser
            // 
            this.ribButtonDropUser.Image = global::KozmoBus.Properties.Resources.DropUser;
            this.ribButtonDropUser.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribButtonDropUser.SmallImage")));
            this.ribButtonDropUser.ToolTip = "Permite elimimar un usuario del sistema.";
            this.ribButtonDropUser.ToolTipImage = global::KozmoBus.Properties.Resources.DropUser;
            this.ribButtonDropUser.ToolTipTitle = "Eliminar usuario.";
            // 
            // ribButtonEditUser
            // 
            this.ribButtonEditUser.Image = global::KozmoBus.Properties.Resources.EditUser;
            this.ribButtonEditUser.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribButtonEditUser.SmallImage")));
            this.ribButtonEditUser.ToolTip = "Permite editar un usuario seleccionado.";
            this.ribButtonEditUser.ToolTipImage = global::KozmoBus.Properties.Resources.EditUser;
            this.ribButtonEditUser.ToolTipTitle = "Editar usuario";
            // 
            // ribPanelPerfiles
            // 
            this.ribPanelPerfiles.Items.Add(this.ribButtonAddProfile);
            this.ribPanelPerfiles.Items.Add(this.ribButtonDropProfile);
            this.ribPanelPerfiles.Items.Add(this.ribButtonEditProfile);
            this.ribPanelPerfiles.Text = "Perfiles";
            // 
            // ribButtonAddProfile
            // 
            this.ribButtonAddProfile.Image = global::KozmoBus.Properties.Resources.AddProfile;
            this.ribButtonAddProfile.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribButtonAddProfile.SmallImage")));
            this.ribButtonAddProfile.ToolTip = "Permite agregar un nuevo perfil de usuario.";
            this.ribButtonAddProfile.ToolTipImage = global::KozmoBus.Properties.Resources.AddProfile;
            this.ribButtonAddProfile.ToolTipTitle = "Agregar perfil.";
            // 
            // ribButtonDropProfile
            // 
            this.ribButtonDropProfile.Image = global::KozmoBus.Properties.Resources.DropProfile;
            this.ribButtonDropProfile.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribButtonDropProfile.SmallImage")));
            this.ribButtonDropProfile.ToolTip = "Permite eliminar un perfil de usuario.";
            this.ribButtonDropProfile.ToolTipImage = global::KozmoBus.Properties.Resources.DropProfile;
            this.ribButtonDropProfile.ToolTipTitle = "Eliminar perfil.";
            // 
            // ribButtonEditProfile
            // 
            this.ribButtonEditProfile.Image = global::KozmoBus.Properties.Resources.EditProfile;
            this.ribButtonEditProfile.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribButtonEditProfile.SmallImage")));
            this.ribButtonEditProfile.ToolTip = "Editar Perfil.";
            this.ribButtonEditProfile.ToolTipImage = global::KozmoBus.Properties.Resources.EditProfile;
            this.ribButtonEditProfile.ToolTipTitle = "Permite editar un perfil de usuario.";
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 324);
            this.Controls.Add(this.ribPadre);
            this.Name = "frmPadre";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribPadre;
        private System.Windows.Forms.RibbonTab ribTabUsuarios;
        private System.Windows.Forms.RibbonPanel ribPanelUsuarios;
        private System.Windows.Forms.RibbonButton ribButtonAddUser;
        private System.Windows.Forms.RibbonButton ribButtonDropUser;
        private System.Windows.Forms.RibbonButton ribButtonEditUser;
        private System.Windows.Forms.RibbonPanel ribPanelPerfiles;
        private System.Windows.Forms.RibbonButton ribButtonAddProfile;
        private System.Windows.Forms.RibbonButton ribButtonDropProfile;
        private System.Windows.Forms.RibbonButton ribButtonEditProfile;

    }
}

