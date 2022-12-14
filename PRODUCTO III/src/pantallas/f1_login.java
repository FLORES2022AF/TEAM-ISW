/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pantallas;

import conexion.Conexion;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author its18
 */
public class f1_login extends javax.swing.JFrame {

    /**
     * Creates new form MENÚ_DUEÑO_2
     */
    public f1_login() {
        initComponents();
        setLocationRelativeTo(null);
        botonIniciarSesion.setEnabled(false);
    }
    
       
     public static int rol, usuario;
     
    private void limpiarCajas(){
        textUsuario.setText(null);       
        tpass.setText(null);       
        setLocationRelativeTo(null);
    }
    

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        cuerpoContenedorLogin = new javax.swing.JPanel();
        logoImagenDePantallaLogin = new javax.swing.JLabel();
        etiquetaIngresarUsuario = new javax.swing.JLabel();
        etiquetaIngresarContrasena = new javax.swing.JLabel();
        lblusuario = new javax.swing.JLabel();
        lblcontra = new javax.swing.JLabel();
        textUsuario = new javax.swing.JTextField();
        tpass = new javax.swing.JPasswordField();
        botonIniciarSesion = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("LOGIN");
        setBackground(new java.awt.Color(255, 255, 255));
        setMinimumSize(new java.awt.Dimension(1000, 500));

        cuerpoContenedorLogin.setBackground(new java.awt.Color(255, 255, 255));
        cuerpoContenedorLogin.setMinimumSize(new java.awt.Dimension(1000, 500));
        cuerpoContenedorLogin.setPreferredSize(new java.awt.Dimension(1000, 500));
        cuerpoContenedorLogin.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        logoImagenDePantallaLogin.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        logoImagenDePantallaLogin.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/1)logoImagenLogin.jpeg"))); // NOI18N
        cuerpoContenedorLogin.add(logoImagenDePantallaLogin, new org.netbeans.lib.awtextra.AbsoluteConstraints(300, 20, -1, 220));
        logoImagenDePantallaLogin.getAccessibleContext().setAccessibleName("imagenLogo");

        etiquetaIngresarUsuario.setFont(new java.awt.Font("Cambria", 0, 14)); // NOI18N
        etiquetaIngresarUsuario.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        etiquetaIngresarUsuario.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/A)iconoUsuarioLogin_1.png"))); // NOI18N
        etiquetaIngresarUsuario.setText("USUARIO:");
        cuerpoContenedorLogin.add(etiquetaIngresarUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 260, 90, 20));

        etiquetaIngresarContrasena.setFont(new java.awt.Font("Cambria", 0, 14)); // NOI18N
        etiquetaIngresarContrasena.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        etiquetaIngresarContrasena.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/B)iconoContrasenaLogin_2.png"))); // NOI18N
        etiquetaIngresarContrasena.setText("CONTRASEÑA:");
        cuerpoContenedorLogin.add(etiquetaIngresarContrasena, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 300, 120, 20));

        lblusuario.setFont(new java.awt.Font("Californian FB", 1, 12)); // NOI18N
        lblusuario.setForeground(new java.awt.Color(255, 0, 0));
        cuerpoContenedorLogin.add(lblusuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(670, 260, -1, -1));

        lblcontra.setFont(new java.awt.Font("Californian FB", 1, 12)); // NOI18N
        lblcontra.setForeground(new java.awt.Color(255, 0, 0));
        cuerpoContenedorLogin.add(lblcontra, new org.netbeans.lib.awtextra.AbsoluteConstraints(670, 300, -1, -1));

        textUsuario.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                textUsuarioKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                textUsuarioKeyTyped(evt);
            }
        });
        cuerpoContenedorLogin.add(textUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(400, 250, 260, 30));

        tpass.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                tpassKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                tpassKeyTyped(evt);
            }
        });
        cuerpoContenedorLogin.add(tpass, new org.netbeans.lib.awtextra.AbsoluteConstraints(400, 290, 260, 30));

        botonIniciarSesion.setBackground(new java.awt.Color(69, 100, 123));
        botonIniciarSesion.setFont(new java.awt.Font("Cambria", 0, 30)); // NOI18N
        botonIniciarSesion.setForeground(new java.awt.Color(255, 255, 255));
        botonIniciarSesion.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/C)iconoBotonLogin_3.png"))); // NOI18N
        botonIniciarSesion.setText("INICIAR SESIÓN");
        botonIniciarSesion.setBorder(null);
        botonIniciarSesion.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonIniciarSesionActionPerformed(evt);
            }
        });
        cuerpoContenedorLogin.add(botonIniciarSesion, new org.netbeans.lib.awtextra.AbsoluteConstraints(390, 340, 270, 70));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(cuerpoContenedorLogin, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(cuerpoContenedorLogin, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents
 
    private void botonIniciarSesionActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonIniciarSesionActionPerformed
    String user = textUsuario.getText();
        String password = String.valueOf(tpass.getPassword());        
        Conexion baseDatos = new Conexion().conectar();   
        
        ResultSet resultado = baseDatos.consultar("SELECT * FROM USUARIOS, T_usuarios WHERE usuario = '" +user+ "' AND clave = '"+password+"'");                         
                            
 
        try{ 

            if(resultado.next()){
            while(resultado.next()){
                rol = resultado.getInt("t_usuario");
                if(rol == 1){
                    new f2_menuDueno().setVisible(true);
                   dispose();
                }else{
                    new f2_menuEncargado().setVisible(true);
                   dispose();
                }
            }

            }else{
             JOptionPane.showMessageDialog(null, "Usuario o contraseña incorrectos");
            }
        }catch(SQLException e){
            System.out.println(e);
        }

    }//GEN-LAST:event_botonIniciarSesionActionPerformed

    private void textUsuarioKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_textUsuarioKeyReleased
        validar();
    }//GEN-LAST:event_textUsuarioKeyReleased

    private void tpassKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_tpassKeyReleased
         validar();

    }//GEN-LAST:event_tpassKeyReleased

    private void textUsuarioKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_textUsuarioKeyTyped
if(textUsuario.getText().length() >= 20)
    {
        evt.consume();
    }        // TODO add your handling code here:
    }//GEN-LAST:event_textUsuarioKeyTyped

    private void tpassKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_tpassKeyTyped
   if(tpass.getText().length() >= 20)
    {
        evt.consume();
    }       // TODO add your handling code here:
    }//GEN-LAST:event_tpassKeyTyped

    /**
     * @param args the command line arguments
     */
    
    public void validar(){
    
        if(textUsuario.getText().isEmpty()){
            lblusuario.setText("*Campo requerido");
        }else{
            lblusuario.setText("");
        }
        if(tpass.getText().isEmpty()){
            lblcontra.setText("*Campo requerido");
            
        }else{
            lblcontra.setText("");
        }
        
        
        
        if(textUsuario.getText().isEmpty() || tpass.getText().isEmpty()){
            botonIniciarSesion.setEnabled(false);
        }else
            botonIniciarSesion.setEnabled(true);
    }
    
    
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
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
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
    private javax.swing.JPanel cuerpoContenedorLogin;
    private javax.swing.JLabel etiquetaIngresarContrasena;
    private javax.swing.JLabel etiquetaIngresarUsuario;
    private javax.swing.JLabel lblcontra;
    private javax.swing.JLabel lblusuario;
    private javax.swing.JLabel logoImagenDePantallaLogin;
    private javax.swing.JTextField textUsuario;
    private javax.swing.JPasswordField tpass;
    // End of variables declaration//GEN-END:variables
}
