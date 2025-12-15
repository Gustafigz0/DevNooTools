using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevNooTools.Data;
using DevNooTools.Models;

namespace DevNooTools.Forms
{
    public class LoginForm : Form
    {
        private UserRepository userRepository;
        
        // Controls
        private Panel panelMain;
        private Panel panelLogo;
        private Panel panelLogoIcon;
        private Label labelLogo;
        private Label labelLogoSub;
        private Label labelWelcome;
        
        private Panel panelForm;
        private Label lblUsername;
        private RoundedTextBox textUsername;
        private Label lblPassword;
        private RoundedTextBox textPassword;
        private CheckBox chkRemember;
        private RoundedButton btnLogin;
        private RoundedButton btnRegister;
        private Label labelError;
        
        private Panel panelFooter;
        private Label labelVersion;
        
        // Animation
        private Timer fadeTimer;
        private float fadeProgress = 0f;

        public User LoggedInUser { get; private set; }

        public LoginForm(UserRepository repository)
        {
            userRepository = repository;
            InitializeComponent();
            
            this.Opacity = 0;
            fadeTimer = new Timer { Interval = 16 };
            fadeTimer.Tick += FadeTimer_Tick;
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            fadeProgress += 0.05f;
            this.Opacity = Math.Min(1.0, fadeProgress);
            if (this.Opacity >= 1.0)
            {
                fadeTimer.Stop();
                textUsername?.Focus();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fadeTimer.Start();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form settings
            this.Text = "DevNooTools - Login";
            this.Size = new Size(450, 620);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ThemeManager.BgPrimary;
            this.Font = new Font("Segoe UI", 9F);
            this.DoubleBuffered = true;

            // Main panel
            panelMain = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Padding = new Padding(40, 32, 40, 32),
                AutoScroll = true
            };
            this.Controls.Add(panelMain);

            // Logo panel
            panelLogo = new Panel
            {
                Dock = DockStyle.Top,
                Height = 120,
                BackColor = Color.Transparent
            };
            panelLogo.Resize += (s, e) => CenterLogoContent();
            panelMain.Controls.Add(panelLogo);

            // Logo icon circle
            panelLogoIcon = new Panel
            {
                Size = new Size(70, 70),
                Location = new Point(0, 10),
                BackColor = ThemeManager.AccentBlue
            };
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, 70, 70);
                panelLogoIcon.Region = new Region(path);
            }
            panelLogo.Controls.Add(panelLogoIcon);

            // Logo label inside circle
            labelLogo = new Label
            {
                Text = "DN",
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(70, 70),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelLogoIcon.Controls.Add(labelLogo);

            labelLogoSub = new Label
            {
                Text = "DevNooTools",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = ThemeManager.TextPrimary,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(0, 85)
            };
            panelLogo.Controls.Add(labelLogoSub);

            // Welcome label
            labelWelcome = new Label
            {
                Text = "Bem-vindo de volta!",
                Font = new Font("Segoe UI", 11F),
                ForeColor = ThemeManager.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelMain.Controls.Add(labelWelcome);
            labelWelcome.BringToFront();

            // Spacer
            var spacer1 = new Panel { Dock = DockStyle.Top, Height = 20, BackColor = Color.Transparent };
            panelMain.Controls.Add(spacer1);
            spacer1.BringToFront();

            // Form panel
            panelForm = new Panel
            {
                Dock = DockStyle.Top,
                Height = 300,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 20, 0, 0)
            };
            panelForm.Resize += PanelForm_Resize;
            panelMain.Controls.Add(panelForm);
            panelForm.BringToFront();

            // Username
            lblUsername = new Label
            {
                Text = "Nome de utilizador",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                Location = new Point(0, 0),
                AutoSize = true
            };
            panelForm.Controls.Add(lblUsername);

            textUsername = new RoundedTextBox
            {
                Location = new Point(0, 22),
                Size = new Size(this.Width - 80 - 40, 42),
                Radius = 10,
                BackColor = ThemeManager.BgInput,
                ForeColor = ThemeManager.TextPrimary,
                BorderColor = ThemeManager.BorderDefault,
                FocusBorderColor = ThemeManager.AccentBlue
            };
            panelForm.Controls.Add(textUsername);

            // Password
            lblPassword = new Label
            {
                Text = "Palavra-passe",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                Location = new Point(0, 74),
                AutoSize = true
            };
            panelForm.Controls.Add(lblPassword);

            textPassword = new RoundedTextBox
            {
                Location = new Point(0, 96),
                Size = new Size(this.Width - 80 - 40, 42),
                Radius = 10,
                BackColor = ThemeManager.BgInput,
                ForeColor = ThemeManager.TextPrimary,
                BorderColor = ThemeManager.BorderDefault,
                FocusBorderColor = ThemeManager.AccentBlue
            };
            textPassword.SetPasswordMode(true);
            panelForm.Controls.Add(textPassword);

            // Remember checkbox
            chkRemember = new CheckBox
            {
                Text = "Lembrar-me",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                BackColor = Color.Transparent,
                Location = new Point(0, 148),
                AutoSize = true
            };
            panelForm.Controls.Add(chkRemember);

            // Error label
            labelError = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.AccentRed,
                BackColor = Color.Transparent,
                Location = new Point(0, 175),
                AutoSize = false,
                Size = new Size(this.Width - 80 - 40, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelForm.Controls.Add(labelError);

            // Login button
            btnLogin = new RoundedButton
            {
                Text = "Entrar",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = ThemeManager.AccentBlue,
                GradientEndColor = ThemeManager.AccentBlueDark,
                Location = new Point(0, 200),
                Size = new Size(this.Width - 80 - 40, 44),
                Radius = 10,
                UseGradient = true
            };
            btnLogin.Click += BtnLogin_Click;
            panelForm.Controls.Add(btnLogin);

            // Register button
            btnRegister = new RoundedButton
            {
                Text = "Criar nova conta",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                BackColor = ThemeManager.BgSecondary,
                GradientEndColor = ThemeManager.BgHover,
                Location = new Point(0, 252),
                Size = new Size(this.Width - 80 - 40, 38),
                Radius = 10,
                UseGradient = false
            };
            btnRegister.Click += BtnRegister_Click;
            panelForm.Controls.Add(btnRegister);

            // Footer
            panelFooter = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                BackColor = Color.Transparent
            };
            panelMain.Controls.Add(panelFooter);

            labelVersion = new Label
            {
                Text = "DevNooTools v2.0 • © 2024",
                Font = new Font("Segoe UI", 8F),
                ForeColor = ThemeManager.TextMuted,
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelFooter.Controls.Add(labelVersion);

            // Enter key handlers
            textUsername.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) textPassword.Focus(); };
            textPassword.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnLogin_Click(s, e); };

            PanelForm_Resize(null, EventArgs.Empty);
            CenterLogoContent();
            this.ResumeLayout(false);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Por favor, insira o nome de utilizador.");
                textUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("Por favor, insira a palavra-passe.");
                textPassword.Focus();
                return;
            }

            if (userRepository.Login(username, password))
            {
                LoggedInUser = userRepository.CurrentUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ShowError("Nome de utilizador ou palavra-passe incorretos.");
                ShakeForm();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterForm(userRepository))
            {
                if (registerForm.ShowDialog() == DialogResult.OK)
                {
                    textUsername.Text = registerForm.RegisteredUsername;
                    textPassword.Text = "";
                    ShowSuccess("Conta criada com sucesso! Faça login.");
                }
            }
        }

        private void ShowError(string message)
        {
            labelError.ForeColor = ThemeManager.AccentRed;
            labelError.Text = message;
        }

        private void ShowSuccess(string message)
        {
            labelError.ForeColor = ThemeManager.AccentGreen;
            labelError.Text = message;
        }

        private void ShakeForm()
        {
            var original = this.Location;
            var shakeTimer = new Timer { Interval = 30 };
            int shakeCount = 0;
            shakeTimer.Tick += (s, e) =>
            {
                shakeCount++;
                int offset = (shakeCount % 2 == 0) ? 8 : -8;
                this.Location = new Point(original.X + offset, original.Y);
                
                if (shakeCount >= 6)
                {
                    shakeTimer.Stop();
                    shakeTimer.Dispose();
                    this.Location = original;
                }
            };
            shakeTimer.Start();
        }

        private void PanelForm_Resize(object sender, EventArgs e)
        {
            if (panelForm == null)
                return;

            int width = panelForm.ClientSize.Width;
            if (width <= 0)
                return;

            void Stretch(Control ctrl)
            {
                if (ctrl != null)
                {
                    ctrl.Width = width;
                }
            }

            Stretch(textUsername);
            Stretch(textPassword);
            Stretch(btnLogin);
            Stretch(btnRegister);
            if (labelError != null)
            {
                labelError.Width = width;
            }
        }

        private void CenterLogoContent()
        {
            if (panelLogo == null)
                return;

            if (panelLogoIcon != null)
            {
                panelLogoIcon.Left = (panelLogo.Width - panelLogoIcon.Width) / 2;
            }

            if (labelLogoSub != null)
            {
                labelLogoSub.Left = (panelLogo.Width - labelLogoSub.Width) / 2;
            }
        }

    }

    public class RegisterForm : Form
    {
        private UserRepository userRepository;
        
        private Panel panelMain;
        private Panel registerFormPanel;
        private Label lblUsername;
        private RoundedTextBox textUsername;
        private Label lblDisplayName;
        private RoundedTextBox textDisplayName;
        private Label lblPassword;
        private RoundedTextBox textPassword;
        private Label lblConfirmPassword;
        private RoundedTextBox textConfirmPassword;
        private Label labelError;
        private RoundedButton btnRegister;
        private RoundedButton btnCancel;

        public string RegisteredUsername { get; private set; }

        public RegisterForm(UserRepository repository)
        {
            userRepository = repository;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Text = "Criar Conta";
            this.Size = new Size(400, 540);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = ThemeManager.BgPrimary;
            this.Font = new Font("Segoe UI", 9F);

            panelMain = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Padding = new Padding(40, 28, 40, 32),
                AutoScroll = true
            };
            this.Controls.Add(panelMain);

            registerFormPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };
            registerFormPanel.Resize += RegisterFormPanel_Resize;
            panelMain.Controls.Add(registerFormPanel);

            int y = 0;
            int fieldHeight = 42;
            int spacing = 58;

            // Username
            lblUsername = new Label
            {
                Text = "Nome de utilizador",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                Location = new Point(0, y),
                AutoSize = true
            };
            registerFormPanel.Controls.Add(lblUsername);

            textUsername = new RoundedTextBox
            {
                Location = new Point(0, y + 18),
                Size = new Size(300, fieldHeight),
                Radius = 10,
                BackColor = ThemeManager.BgInput,
                ForeColor = ThemeManager.TextPrimary,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            registerFormPanel.Controls.Add(textUsername);

            y += spacing;

            // Display Name
            lblDisplayName = new Label
            {
                Text = "Nome de exibição",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                Location = new Point(0, y),
                AutoSize = true
            };
            registerFormPanel.Controls.Add(lblDisplayName);

            textDisplayName = new RoundedTextBox
            {
                Location = new Point(0, y + 18),
                Size = new Size(300, fieldHeight),
                Radius = 10,
                BackColor = ThemeManager.BgInput,
                ForeColor = ThemeManager.TextPrimary,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            registerFormPanel.Controls.Add(textDisplayName);

            y += spacing;

            // Password
            lblPassword = new Label
            {
                Text = "Palavra-passe",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                Location = new Point(0, y),
                AutoSize = true
            };
            registerFormPanel.Controls.Add(lblPassword);

            textPassword = new RoundedTextBox
            {
                Location = new Point(0, y + 18),
                Size = new Size(300, fieldHeight),
                Radius = 10,
                BackColor = ThemeManager.BgInput,
                ForeColor = ThemeManager.TextPrimary,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            textPassword.SetPasswordMode(true);
            registerFormPanel.Controls.Add(textPassword);

            y += spacing;

            // Confirm Password
            lblConfirmPassword = new Label
            {
                Text = "Confirmar palavra-passe",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                Location = new Point(0, y),
                AutoSize = true
            };
            registerFormPanel.Controls.Add(lblConfirmPassword);

            textConfirmPassword = new RoundedTextBox
            {
                Location = new Point(0, y + 18),
                Size = new Size(300, fieldHeight),
                Radius = 10,
                BackColor = ThemeManager.BgInput,
                ForeColor = ThemeManager.TextPrimary,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            textConfirmPassword.SetPasswordMode(true);
            registerFormPanel.Controls.Add(textConfirmPassword);

            y += spacing;

            // Error label
            labelError = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.AccentRed,
                Location = new Point(0, y),
                Size = new Size(300, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            registerFormPanel.Controls.Add(labelError);

            y += 25;

            // Register button
            btnRegister = new RoundedButton
            {
                Text = "Criar Conta",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = ThemeManager.AccentGreen,
                GradientEndColor = ThemeManager.AccentGreenDark,
                Location = new Point(0, y),
                Size = new Size(300, 44),
                Radius = 10,
                UseGradient = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            btnRegister.Click += BtnRegister_Click;
            registerFormPanel.Controls.Add(btnRegister);

            y += 52;

            // Cancel button
            btnCancel = new RoundedButton
            {
                Text = "Cancelar",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                BackColor = ThemeManager.BgSecondary,
                Location = new Point(0, y),
                Size = new Size(300, 38),
                Radius = 10,
                UseGradient = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            registerFormPanel.Controls.Add(btnCancel);

            RegisterFormPanel_Resize(null, EventArgs.Empty);
            this.ResumeLayout(false);
        }

        private void RegisterFormPanel_Resize(object sender, EventArgs e)
        {
            int width = registerFormPanel?.ClientSize.Width ?? 0;
            if (width <= 0)
                return;

            void Stretch(Control ctrl)
            {
                if (ctrl != null)
                    ctrl.Width = width;
            }

            Stretch(textUsername);
            Stretch(textDisplayName);
            Stretch(textPassword);
            Stretch(textConfirmPassword);
            Stretch(btnRegister);
            Stretch(btnCancel);
            if (labelError != null)
                labelError.Width = width;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string displayName = textDisplayName.Text.Trim();
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("O nome de utilizador é obrigatório.");
                return;
            }

            if (username.Length < 3)
            {
                ShowError("O nome de utilizador deve ter pelo menos 3 caracteres.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("A palavra-passe é obrigatória.");
                return;
            }

            if (password.Length < 4)
            {
                ShowError("A palavra-passe deve ter pelo menos 4 caracteres.");
                return;
            }

            if (password != confirmPassword)
            {
                ShowError("As palavras-passe não coincidem.");
                return;
            }

            if (string.IsNullOrWhiteSpace(displayName))
            {
                displayName = username;
            }

            if (userRepository.Register(username, password, displayName))
            {
                RegisteredUsername = username;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ShowError("Este nome de utilizador já está em uso.");
            }
        }

        private void ShowError(string message)
        {
            labelError.Text = message;
        }
    }
}
