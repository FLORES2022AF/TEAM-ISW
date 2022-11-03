package pantallas;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f1_login extends javax.swing.JFrame {

    public f1_login() {
        initComponents();
    }
    
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormLogin = new javax.swing.JPanel();
        cajaImagenLaTipica = new javax.swing.JLabel();
        etiquetaUsuarioL = new javax.swing.JLabel();
        cajaDeTextoIngreseUsuario = new javax.swing.JTextField();
        etiquetaContrasenaL = new javax.swing.JLabel();
        cajaDeTextoIngreseContrasena = new javax.swing.JPasswordField();
        botonIniciarSesion = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("LOGIN");

        contenedorFormLogin.setBackground(new java.awt.Color(255, 255, 255));
        contenedorFormLogin.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        cajaImagenLaTipica.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/1_logoImagenLogin.jpeg"))); // NOI18N
        contenedorFormLogin.add(cajaImagenLaTipica, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 20, -1, -1));

        etiquetaUsuarioL.setFont(new java.awt.Font("Cambria", 0, 14)); // NOI18N
        etiquetaUsuarioL.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoUsuarioLogin_1.png"))); // NOI18N
        etiquetaUsuarioL.setText("USUARIO:");
        contenedorFormLogin.add(etiquetaUsuarioL, new org.netbeans.lib.awtextra.AbsoluteConstraints(290, 310, -1, -1));

        cajaDeTextoIngreseUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        cajaDeTextoIngreseUsuario.setForeground(new java.awt.Color(204, 204, 204));
        cajaDeTextoIngreseUsuario.setText("Ingrese su correo como usuario");
        contenedorFormLogin.add(cajaDeTextoIngreseUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 310, 300, -1));

        etiquetaContrasenaL.setFont(new java.awt.Font("Cambria", 0, 14)); // NOI18N
        etiquetaContrasenaL.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoContrasenaLogin_2.png"))); // NOI18N
        etiquetaContrasenaL.setText("CONTRASEÑA:");
        contenedorFormLogin.add(etiquetaContrasenaL, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 340, -1, -1));

        cajaDeTextoIngreseContrasena.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        cajaDeTextoIngreseContrasena.setForeground(new java.awt.Color(153, 153, 153));
        cajaDeTextoIngreseContrasena.setText("Ingrese su contraseña");
        contenedorFormLogin.add(cajaDeTextoIngreseContrasena, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 340, 300, -1));

        botonIniciarSesion.setBackground(new java.awt.Color(97, 114, 126));
        botonIniciarSesion.setFont(new java.awt.Font("Cambria", 0, 30)); // NOI18N
        botonIniciarSesion.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBotonLogin_3.png"))); // NOI18N
        botonIniciarSesion.setText("    INICIAR SESIÓN");
        contenedorFormLogin.add(botonIniciarSesion, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 410, 330, 70));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormLogin, javax.swing.GroupLayout.DEFAULT_SIZE, 1000, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormLogin, javax.swing.GroupLayout.DEFAULT_SIZE, 580, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(f1_login.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f1_login.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f1_login.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f1_login.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new f1_login().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton botonIniciarSesion;
    private javax.swing.JPasswordField cajaDeTextoIngreseContrasena;
    private javax.swing.JTextField cajaDeTextoIngreseUsuario;
    private javax.swing.JLabel cajaImagenLaTipica;
    private javax.swing.JPanel contenedorFormLogin;
    private javax.swing.JLabel etiquetaContrasenaL;
    private javax.swing.JLabel etiquetaUsuarioL;
    // End of variables declaration//GEN-END:variables
}
