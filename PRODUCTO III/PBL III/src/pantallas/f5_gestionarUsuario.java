package pantallas;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f5_gestionarUsuario extends javax.swing.JFrame {

    public f5_gestionarUsuario() {
        initComponents();
    }
    
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormGestionarUsuario = new javax.swing.JPanel();
        etiquetaBusquedaPor = new javax.swing.JLabel();
        filtroDeBusqueda = new javax.swing.JComboBox<>();
        valorBusqueda = new javax.swing.JTextField();
        botonBusquedaUsuarioGU = new javax.swing.JButton();
        etiquetaIdUsuario = new javax.swing.JLabel();
        cajaDeTextoIngreseUsuarioId = new javax.swing.JTextField();
        etiquetaNombreUsuario = new javax.swing.JLabel();
        cajaDeTextoIngreseUsuarioNombre = new javax.swing.JTextField();
        etiquetaApellidoPaternoUsuario = new javax.swing.JLabel();
        cajaDeTextoIngreseUsuarioApellidoPaterno = new javax.swing.JTextField();
        etiquetaApellidoMaternoUsuario = new javax.swing.JLabel();
        cajaDeTextoIngreseUsuarioApellidoMaterno = new javax.swing.JTextField();
        etiquetaUsuarioCorreoGU = new javax.swing.JLabel();
        cajaDeTextoIngreseUsuarioCorreo = new javax.swing.JTextField();
        etiquetaContraseñaGU = new javax.swing.JLabel();
        cajaDeTextoIngreseUsuarioContrasena = new javax.swing.JTextField();
        etiquetaTipoDeUsuarioGU = new javax.swing.JLabel();
        seleccionarTipoUsuarioOpcion1Dueno = new javax.swing.JRadioButton();
        seleccionarTipoUsuarioOpcion2Encargado = new javax.swing.JRadioButton();
        botonDarDeAltaUsuario = new javax.swing.JButton();
        botonModificarUsuario = new javax.swing.JButton();
        botonBorrarUsuario = new javax.swing.JButton();
        botonRegresarAMenu = new javax.swing.JButton();
        fondoDelFormGU = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("GESTIONAR USUARIO");

        contenedorFormGestionarUsuario.setBackground(new java.awt.Color(102, 204, 255));
        contenedorFormGestionarUsuario.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        etiquetaBusquedaPor.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaBusquedaPor.setText("BUSCAR POR:");
        contenedorFormGestionarUsuario.add(etiquetaBusquedaPor, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 150, 70, 20));

        filtroDeBusqueda.setBackground(new java.awt.Color(147, 175, 197));
        filtroDeBusqueda.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        filtroDeBusqueda.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "ID USUARIO", "NOMBRE USUARIO", "APELLIDO PATERNO", "APELLIDO MATERNO", "USUARIO CORREO", " " }));
        filtroDeBusqueda.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                filtroDeBusquedaActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(filtroDeBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(180, 150, 170, -1));
        contenedorFormGestionarUsuario.add(valorBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 150, 280, -1));

        botonBusquedaUsuarioGU.setBackground(new java.awt.Color(74, 96, 106));
        botonBusquedaUsuarioGU.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBusquedaUsuarioGU.setForeground(new java.awt.Color(255, 255, 255));
        botonBusquedaUsuarioGU.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBusquedaDeUsuario_GU_1.png"))); // NOI18N
        botonBusquedaUsuarioGU.setText("BUSCAR USUARIO");
        contenedorFormGestionarUsuario.add(botonBusquedaUsuarioGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(650, 130, 170, -1));

        etiquetaIdUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaIdUsuario.setText("Id Usuario:");
        contenedorFormGestionarUsuario.add(etiquetaIdUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 200, -1, -1));

        cajaDeTextoIngreseUsuarioId.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cajaDeTextoIngreseUsuarioIdActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(cajaDeTextoIngreseUsuarioId, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 200, 140, 20));

        etiquetaNombreUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaNombreUsuario.setText("Nombre:");
        contenedorFormGestionarUsuario.add(etiquetaNombreUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 230, -1, -1));
        contenedorFormGestionarUsuario.add(cajaDeTextoIngreseUsuarioNombre, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 230, 610, 20));

        etiquetaApellidoPaternoUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaApellidoPaternoUsuario.setText("Apellido Paterno:");
        contenedorFormGestionarUsuario.add(etiquetaApellidoPaternoUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 260, -1, -1));
        contenedorFormGestionarUsuario.add(cajaDeTextoIngreseUsuarioApellidoPaterno, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 260, 610, 20));

        etiquetaApellidoMaternoUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaApellidoMaternoUsuario.setText("Apellido Materno:");
        contenedorFormGestionarUsuario.add(etiquetaApellidoMaternoUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 290, -1, -1));
        contenedorFormGestionarUsuario.add(cajaDeTextoIngreseUsuarioApellidoMaterno, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 290, 610, 20));

        etiquetaUsuarioCorreoGU.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaUsuarioCorreoGU.setText("Usuario:");
        contenedorFormGestionarUsuario.add(etiquetaUsuarioCorreoGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 330, -1, -1));
        contenedorFormGestionarUsuario.add(cajaDeTextoIngreseUsuarioCorreo, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 330, 360, 20));

        etiquetaContraseñaGU.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaContraseñaGU.setText("Contraseña:");
        contenedorFormGestionarUsuario.add(etiquetaContraseñaGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 360, -1, -1));
        contenedorFormGestionarUsuario.add(cajaDeTextoIngreseUsuarioContrasena, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 360, 360, 20));

        etiquetaTipoDeUsuarioGU.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaTipoDeUsuarioGU.setText("Tipo De Usuario:");
        contenedorFormGestionarUsuario.add(etiquetaTipoDeUsuarioGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 390, -1, -1));

        seleccionarTipoUsuarioOpcion1Dueno.setText("Dueño");
        contenedorFormGestionarUsuario.add(seleccionarTipoUsuarioOpcion1Dueno, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 390, -1, -1));

        seleccionarTipoUsuarioOpcion2Encargado.setText("Encargado");
        contenedorFormGestionarUsuario.add(seleccionarTipoUsuarioOpcion2Encargado, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 390, -1, -1));

        botonDarDeAltaUsuario.setBackground(new java.awt.Color(74, 96, 106));
        botonDarDeAltaUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonDarDeAltaUsuario.setForeground(new java.awt.Color(255, 255, 255));
        botonDarDeAltaUsuario.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoDarDeAltaUsuarioGestionarUsuario_2.png"))); // NOI18N
        botonDarDeAltaUsuario.setText("DAR DE ALTA USUARIO");
        contenedorFormGestionarUsuario.add(botonDarDeAltaUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(190, 420, 190, -1));

        botonModificarUsuario.setBackground(new java.awt.Color(74, 96, 106));
        botonModificarUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonModificarUsuario.setForeground(new java.awt.Color(255, 255, 255));
        botonModificarUsuario.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoModificarUsuarioGestionarUsuario_2.png"))); // NOI18N
        botonModificarUsuario.setText("MODIFICAR USUARIO");
        botonModificarUsuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonModificarUsuarioActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(botonModificarUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(390, 420, 180, -1));

        botonBorrarUsuario.setBackground(new java.awt.Color(74, 96, 106));
        botonBorrarUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBorrarUsuario.setForeground(new java.awt.Color(255, 255, 255));
        botonBorrarUsuario.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBorrarUsuarioGestionarUsuario_4.png"))); // NOI18N
        botonBorrarUsuario.setText("BORRAR USUARIO");
        botonBorrarUsuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonBorrarUsuarioActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(botonBorrarUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(580, 420, 180, -1));

        botonRegresarAMenu.setBackground(new java.awt.Color(74, 96, 106));
        botonRegresarAMenu.setFont(new java.awt.Font("Cambria", 0, 30)); // NOI18N
        botonRegresarAMenu.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAMenu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBotonRegresarAMenu_GU_5.png"))); // NOI18N
        botonRegresarAMenu.setText("REGRESAR A MENÚ");
        contenedorFormGestionarUsuario.add(botonRegresarAMenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 490, 360, 70));

        fondoDelFormGU.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/5_fondoPantallaGestionarUsuario.jpeg"))); // NOI18N
        fondoDelFormGU.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        contenedorFormGestionarUsuario.add(fondoDelFormGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 580));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGestionarUsuario, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGestionarUsuario, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void filtroDeBusquedaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_filtroDeBusquedaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_filtroDeBusquedaActionPerformed

    private void cajaDeTextoIngreseUsuarioIdActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cajaDeTextoIngreseUsuarioIdActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cajaDeTextoIngreseUsuarioIdActionPerformed

    private void botonModificarUsuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonModificarUsuarioActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_botonModificarUsuarioActionPerformed

    private void botonBorrarUsuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonBorrarUsuarioActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_botonBorrarUsuarioActionPerformed
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
            java.util.logging.Logger.getLogger(f5_gestionarUsuario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f5_gestionarUsuario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f5_gestionarUsuario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f5_gestionarUsuario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
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
                new f5_gestionarUsuario().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton botonBorrarUsuario;
    private javax.swing.JButton botonBusquedaUsuarioGU;
    private javax.swing.JButton botonDarDeAltaUsuario;
    private javax.swing.JButton botonModificarUsuario;
    private javax.swing.JButton botonRegresarAMenu;
    private javax.swing.JTextField cajaDeTextoIngreseUsuarioApellidoMaterno;
    private javax.swing.JTextField cajaDeTextoIngreseUsuarioApellidoPaterno;
    private javax.swing.JTextField cajaDeTextoIngreseUsuarioContrasena;
    private javax.swing.JTextField cajaDeTextoIngreseUsuarioCorreo;
    private javax.swing.JTextField cajaDeTextoIngreseUsuarioId;
    private javax.swing.JTextField cajaDeTextoIngreseUsuarioNombre;
    private javax.swing.JPanel contenedorFormGestionarUsuario;
    private javax.swing.JLabel etiquetaApellidoMaternoUsuario;
    private javax.swing.JLabel etiquetaApellidoPaternoUsuario;
    private javax.swing.JLabel etiquetaBusquedaPor;
    private javax.swing.JLabel etiquetaContraseñaGU;
    private javax.swing.JLabel etiquetaIdUsuario;
    private javax.swing.JLabel etiquetaNombreUsuario;
    private javax.swing.JLabel etiquetaTipoDeUsuarioGU;
    private javax.swing.JLabel etiquetaUsuarioCorreoGU;
    private javax.swing.JComboBox<String> filtroDeBusqueda;
    private javax.swing.JLabel fondoDelFormGU;
    private javax.swing.JRadioButton seleccionarTipoUsuarioOpcion1Dueno;
    private javax.swing.JRadioButton seleccionarTipoUsuarioOpcion2Encargado;
    private javax.swing.JTextField valorBusqueda;
    // End of variables declaration//GEN-END:variables
}
