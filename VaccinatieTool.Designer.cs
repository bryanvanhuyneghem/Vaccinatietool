
namespace Vaccinatietool
{
    partial class VaccinatieTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBurgerNaam = new System.Windows.Forms.Label();
            this.lblBurgerVoornaam = new System.Windows.Forms.Label();
            this.lblPersoonsgegevens = new System.Windows.Forms.Label();
            this.lblVaccinatie = new System.Windows.Forms.Label();
            this.lblVaccinProducent = new System.Windows.Forms.Label();
            this.lblVaccinType = new System.Windows.Forms.Label();
            this.lblVaccin = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.cbVaccin = new System.Windows.Forms.ComboBox();
            this.lblVaccinator = new System.Windows.Forms.Label();
            this.cbVaccinator = new System.Windows.Forms.ComboBox();
            this.btnVaccineer = new System.Windows.Forms.Button();
            this.btnZoekVaccinaties = new System.Windows.Forms.Button();
            this.lvVaccinaties = new System.Windows.Forms.ListView();
            this.lvVaccinnaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvVaccinProducent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvVaccinType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDatumToegediend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCovidSafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBurgerNaam
            // 
            this.lblBurgerNaam.AutoSize = true;
            this.lblBurgerNaam.Location = new System.Drawing.Point(32, 46);
            this.lblBurgerNaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBurgerNaam.Name = "lblBurgerNaam";
            this.lblBurgerNaam.Size = new System.Drawing.Size(38, 13);
            this.lblBurgerNaam.TabIndex = 0;
            this.lblBurgerNaam.Text = "Naam:";
            this.lblBurgerNaam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBurgerVoornaam
            // 
            this.lblBurgerVoornaam.AutoSize = true;
            this.lblBurgerVoornaam.Location = new System.Drawing.Point(11, 83);
            this.lblBurgerVoornaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBurgerVoornaam.Name = "lblBurgerVoornaam";
            this.lblBurgerVoornaam.Size = new System.Drawing.Size(58, 13);
            this.lblBurgerVoornaam.TabIndex = 1;
            this.lblBurgerVoornaam.Text = "Voornaam:";
            this.lblBurgerVoornaam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPersoonsgegevens
            // 
            this.lblPersoonsgegevens.AutoSize = true;
            this.lblPersoonsgegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersoonsgegevens.Location = new System.Drawing.Point(61, 7);
            this.lblPersoonsgegevens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersoonsgegevens.Name = "lblPersoonsgegevens";
            this.lblPersoonsgegevens.Size = new System.Drawing.Size(161, 20);
            this.lblPersoonsgegevens.TabIndex = 5;
            this.lblPersoonsgegevens.Text = "Persoonsgegevens";
            // 
            // lblVaccinatie
            // 
            this.lblVaccinatie.AutoSize = true;
            this.lblVaccinatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccinatie.Location = new System.Drawing.Point(399, 7);
            this.lblVaccinatie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaccinatie.Name = "lblVaccinatie";
            this.lblVaccinatie.Size = new System.Drawing.Size(140, 20);
            this.lblVaccinatie.TabIndex = 6;
            this.lblVaccinatie.Text = "Vaccingegevens";
            // 
            // lblVaccinProducent
            // 
            this.lblVaccinProducent.AutoSize = true;
            this.lblVaccinProducent.Location = new System.Drawing.Point(362, 83);
            this.lblVaccinProducent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaccinProducent.Name = "lblVaccinProducent";
            this.lblVaccinProducent.Size = new System.Drawing.Size(59, 13);
            this.lblVaccinProducent.TabIndex = 8;
            this.lblVaccinProducent.Text = "Producent:";
            // 
            // lblVaccinType
            // 
            this.lblVaccinType.AutoSize = true;
            this.lblVaccinType.Location = new System.Drawing.Point(386, 119);
            this.lblVaccinType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaccinType.Name = "lblVaccinType";
            this.lblVaccinType.Size = new System.Drawing.Size(34, 13);
            this.lblVaccinType.TabIndex = 9;
            this.lblVaccinType.Text = "Type:";
            // 
            // lblVaccin
            // 
            this.lblVaccin.AutoSize = true;
            this.lblVaccin.Location = new System.Drawing.Point(379, 48);
            this.lblVaccin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaccin.Name = "lblVaccin";
            this.lblVaccin.Size = new System.Drawing.Size(43, 13);
            this.lblVaccin.TabIndex = 10;
            this.lblVaccin.Text = "Vaccin:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(70, 44);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(147, 20);
            this.txtNaam.TabIndex = 11;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(70, 81);
            this.txtVoornaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(147, 20);
            this.txtVoornaam.TabIndex = 12;
            // 
            // cbVaccin
            // 
            this.cbVaccin.FormattingEnabled = true;
            this.cbVaccin.Location = new System.Drawing.Point(424, 46);
            this.cbVaccin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVaccin.Name = "cbVaccin";
            this.cbVaccin.Size = new System.Drawing.Size(145, 21);
            this.cbVaccin.TabIndex = 16;
            this.cbVaccin.SelectedIndexChanged += new System.EventHandler(this.cbVaccin_SelectedIndexChanged);
            // 
            // lblVaccinator
            // 
            this.lblVaccinator.AutoSize = true;
            this.lblVaccinator.Location = new System.Drawing.Point(360, 158);
            this.lblVaccinator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaccinator.Name = "lblVaccinator";
            this.lblVaccinator.Size = new System.Drawing.Size(61, 13);
            this.lblVaccinator.TabIndex = 17;
            this.lblVaccinator.Text = "Vaccinator:";
            // 
            // cbVaccinator
            // 
            this.cbVaccinator.FormattingEnabled = true;
            this.cbVaccinator.Location = new System.Drawing.Point(424, 155);
            this.cbVaccinator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVaccinator.Name = "cbVaccinator";
            this.cbVaccinator.Size = new System.Drawing.Size(145, 21);
            this.cbVaccinator.TabIndex = 18;
            this.cbVaccinator.SelectedIndexChanged += new System.EventHandler(this.cbVaccinator_SelectedIndexChanged);
            // 
            // btnVaccineer
            // 
            this.btnVaccineer.Location = new System.Drawing.Point(220, 115);
            this.btnVaccineer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVaccineer.Name = "btnVaccineer";
            this.btnVaccineer.Size = new System.Drawing.Size(119, 55);
            this.btnVaccineer.TabIndex = 19;
            this.btnVaccineer.Text = "Voeg vaccinatie toe";
            this.btnVaccineer.UseVisualStyleBackColor = true;
            this.btnVaccineer.Click += new System.EventHandler(this.btnVaccineer_Click);
            // 
            // btnZoekVaccinaties
            // 
            this.btnZoekVaccinaties.Location = new System.Drawing.Point(220, 43);
            this.btnZoekVaccinaties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZoekVaccinaties.Name = "btnZoekVaccinaties";
            this.btnZoekVaccinaties.Size = new System.Drawing.Size(119, 54);
            this.btnZoekVaccinaties.TabIndex = 20;
            this.btnZoekVaccinaties.Text = "Zoek vaccinaties";
            this.btnZoekVaccinaties.UseVisualStyleBackColor = true;
            this.btnZoekVaccinaties.Click += new System.EventHandler(this.btnZoekVaccinaties_Click);
            // 
            // lvVaccinaties
            // 
            this.lvVaccinaties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvVaccinnaam,
            this.lvVaccinProducent,
            this.lvVaccinType,
            this.lvDatumToegediend});
            this.lvVaccinaties.GridLines = true;
            this.lvVaccinaties.HideSelection = false;
            this.lvVaccinaties.Location = new System.Drawing.Point(14, 190);
            this.lvVaccinaties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvVaccinaties.Name = "lvVaccinaties";
            this.lvVaccinaties.Size = new System.Drawing.Size(555, 166);
            this.lvVaccinaties.TabIndex = 21;
            this.lvVaccinaties.UseCompatibleStateImageBehavior = false;
            this.lvVaccinaties.View = System.Windows.Forms.View.Details;
            // 
            // lvVaccinnaam
            // 
            this.lvVaccinnaam.Text = "Vaccinnaam";
            this.lvVaccinnaam.Width = 150;
            // 
            // lvVaccinProducent
            // 
            this.lvVaccinProducent.Text = "Producent";
            this.lvVaccinProducent.Width = 150;
            // 
            // lvVaccinType
            // 
            this.lvVaccinType.Text = "Type";
            this.lvVaccinType.Width = 150;
            // 
            // lvDatumToegediend
            // 
            this.lvDatumToegediend.Text = "Datum toegediend";
            this.lvDatumToegediend.Width = 150;
            // 
            // btnCovidSafe
            // 
            this.btnCovidSafe.Location = new System.Drawing.Point(70, 115);
            this.btnCovidSafe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCovidSafe.Name = "btnCovidSafe";
            this.btnCovidSafe.Size = new System.Drawing.Size(146, 56);
            this.btnCovidSafe.TabIndex = 22;
            this.btnCovidSafe.Text = "Scan CovidSafe-ticket";
            this.btnCovidSafe.UseVisualStyleBackColor = true;
            // 
            // VaccinatieTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 366);
            this.Controls.Add(this.btnCovidSafe);
            this.Controls.Add(this.lvVaccinaties);
            this.Controls.Add(this.btnZoekVaccinaties);
            this.Controls.Add(this.btnVaccineer);
            this.Controls.Add(this.cbVaccinator);
            this.Controls.Add(this.lblVaccinator);
            this.Controls.Add(this.cbVaccin);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblVaccin);
            this.Controls.Add(this.lblVaccinType);
            this.Controls.Add(this.lblVaccinProducent);
            this.Controls.Add(this.lblVaccinatie);
            this.Controls.Add(this.lblPersoonsgegevens);
            this.Controls.Add(this.lblBurgerVoornaam);
            this.Controls.Add(this.lblBurgerNaam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VaccinatieTool";
            this.Text = "VaccinNet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBurgerNaam;
        private System.Windows.Forms.Label lblBurgerVoornaam;
        private System.Windows.Forms.Label lblPersoonsgegevens;
        private System.Windows.Forms.Label lblVaccinatie;
        private System.Windows.Forms.Label lblVaccinProducent;
        private System.Windows.Forms.Label lblVaccinType;
        private System.Windows.Forms.Label lblVaccin;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.ComboBox cbVaccin;
        private System.Windows.Forms.Label lblVaccinator;
        private System.Windows.Forms.ComboBox cbVaccinator;
        private System.Windows.Forms.Button btnVaccineer;
        private System.Windows.Forms.Button btnZoekVaccinaties;
        private System.Windows.Forms.ListView lvVaccinaties;
        private System.Windows.Forms.ColumnHeader lvVaccinnaam;
        private System.Windows.Forms.ColumnHeader lvVaccinProducent;
        private System.Windows.Forms.ColumnHeader lvVaccinType;
        private System.Windows.Forms.ColumnHeader lvDatumToegediend;
        private System.Windows.Forms.Button btnCovidSafe;
    }
}

