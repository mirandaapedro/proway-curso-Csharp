namespace WindowsFormsExemplos.Forms
{
    partial class ProdutoCadastroSimplificadoBancoDadosForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxPrecoUnitario = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelListaProdutos = new System.Windows.Forms.Label();
            this.labelPrecoUnitario = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnQuantidade,
            this.ColumnPrecoUnitario,
            this.ColumnPreço});
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 414);
            this.dataGridView1.TabIndex = 19;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "Código";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 125;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.MinimumWidth = 6;
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.ReadOnly = true;
            this.ColumnQuantidade.Width = 125;
            // 
            // ColumnPrecoUnitario
            // 
            this.ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            this.ColumnPrecoUnitario.MinimumWidth = 6;
            this.ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            this.ColumnPrecoUnitario.ReadOnly = true;
            this.ColumnPrecoUnitario.Width = 125;
            // 
            // ColumnPreço
            // 
            this.ColumnPreço.HeaderText = "Preço";
            this.ColumnPreço.MinimumWidth = 6;
            this.ColumnPreço.Name = "ColumnPreço";
            this.ColumnPreço.ReadOnly = true;
            this.ColumnPreço.Width = 125;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(448, 112);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(341, 23);
            this.textBoxNome.TabIndex = 12;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuantidade.Location = new System.Drawing.Point(448, 156);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(341, 23);
            this.textBoxQuantidade.TabIndex = 14;
            // 
            // textBoxPrecoUnitario
            // 
            this.textBoxPrecoUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrecoUnitario.Location = new System.Drawing.Point(448, 200);
            this.textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            this.textBoxPrecoUnitario.Size = new System.Drawing.Size(341, 23);
            this.textBoxPrecoUnitario.TabIndex = 16;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSalvar.Image = global::WindowsFormsExemplos.Properties.Resources.disk;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(702, 229);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(87, 46);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalvar.UseCompatibleTextRendering = true;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelListaProdutos
            // 
            this.labelListaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelListaProdutos.AutoSize = true;
            this.labelListaProdutos.Location = new System.Drawing.Point(12, 211);
            this.labelListaProdutos.Name = "labelListaProdutos";
            this.labelListaProdutos.Size = new System.Drawing.Size(82, 15);
            this.labelListaProdutos.TabIndex = 17;
            this.labelListaProdutos.Text = "Lista Produtos";
            // 
            // labelPrecoUnitario
            // 
            this.labelPrecoUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrecoUnitario.AutoSize = true;
            this.labelPrecoUnitario.Location = new System.Drawing.Point(448, 182);
            this.labelPrecoUnitario.Name = "labelPrecoUnitario";
            this.labelPrecoUnitario.Size = new System.Drawing.Size(82, 15);
            this.labelPrecoUnitario.TabIndex = 15;
            this.labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(448, 138);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(69, 15);
            this.labelQuantidade.TabIndex = 13;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(448, 94);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 11;
            this.labelNome.Text = "Nome";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.Location = new System.Drawing.Point(286, 104);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 21;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApagar.Location = new System.Drawing.Point(367, 104);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 20;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // ProdutoCadastroSimplificadoBancoDadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsExemplos.Properties.Resources.PAIN;
            this.ClientSize = new System.Drawing.Size(911, 648);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxPrecoUnitario);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelListaProdutos);
            this.Controls.Add(this.labelPrecoUnitario);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Name = "ProdutoCadastroSimplificadoBancoDadosForm";
            this.Text = "ProdutoCadastroSimplificadoBancoDadosForm";
            this.Load += new System.EventHandler(this.ProdutoCadastroSimplificadoBancoDadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxNome;
        private TextBox textBoxQuantidade;
        private TextBox textBoxPrecoUnitario;
        private Button buttonSalvar;
        private Label labelListaProdutos;
        private Label labelPrecoUnitario;
        private Label labelQuantidade;
        private Label labelNome;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
        private DataGridViewTextBoxColumn ColumnPreço;
    }
}