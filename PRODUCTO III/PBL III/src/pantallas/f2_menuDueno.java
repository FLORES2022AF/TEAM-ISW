package pantallas;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f2_menuDueno extends javax.swing.JFrame {

    public f2_menuDueno() {
        initComponents();
    }


    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormMenuDueno = new javax.swing.JPanel();
        iconoPuntoDeVentaMenuDueno_1 = new javax.swing.JLabel();
        botonPuntoDeVenta_D = new javax.swing.JButton();
        iconoGestionarUsuarioMenuDueno_2 = new javax.swing.JLabel();
        botonGestionarUsuario = new javax.swing.JButton();
        iconoGestionarInventarioMenuDueno_3 = new javax.swing.JLabel();
        botonGestionarInventario_D = new javax.swing.JButton();
        iconoGestionarInventarioMenuDueno_4 = new javax.swing.JLabel();
        botonGenerarPreLista_D = new javax.swing.JButton();
        botonCerrarSesion_D = new javax.swing.JButton();
        fondoDelFormMD = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("MENÚ DUEÑO");
        setName("menuDueno"); // NOI18N

        contenedorFormMenuDueno.setBackground(new java.awt.Color(255, 255, 255));
        contenedorFormMenuDueno.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        iconoPuntoDeVentaMenuDueno_1.setBackground(new java.awt.Color(255, 255, 255));
        iconoPuntoDeVentaMenuDueno_1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoPuntoDeVentaMenuDueno_1.png"))); // NOI18N
        contenedorFormMenuDueno.add(iconoPuntoDeVentaMenuDueno_1, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 150, -1, 30));

        botonPuntoDeVenta_D.setBackground(new java.awt.Color(96, 121, 128));
        botonPuntoDeVenta_D.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonPuntoDeVenta_D.setText("PUNTO DE VENTA");
        contenedorFormMenuDueno.add(botonPuntoDeVenta_D, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 150, 360, 40));

        iconoGestionarUsuarioMenuDueno_2.setBackground(new java.awt.Color(255, 255, 255));
        iconoGestionarUsuarioMenuDueno_2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoGestionarUsuarioMenuDueno_2.png"))); // NOI18N
        contenedorFormMenuDueno.add(iconoGestionarUsuarioMenuDueno_2, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 200, -1, 40));

        botonGestionarUsuario.setBackground(new java.awt.Color(96, 121, 128));
        botonGestionarUsuario.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonGestionarUsuario.setText("GESTIONAR USUARIO");
        contenedorFormMenuDueno.add(botonGestionarUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 200, 360, 40));

        iconoGestionarInventarioMenuDueno_3.setBackground(new java.awt.Color(255, 255, 255));
        iconoGestionarInventarioMenuDueno_3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoGestionarInventarioMenuDueno_3.png"))); // NOI18N
        contenedorFormMenuDueno.add(iconoGestionarInventarioMenuDueno_3, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 250, 30, 40));

        botonGestionarInventario_D.setBackground(new java.awt.Color(96, 121, 128));
        botonGestionarInventario_D.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonGestionarInventario_D.setText("GESTIONAR INVENTARIO");
        botonGestionarInventario_D.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonGestionarInventario_DActionPerformed(evt);
            }
        });
        contenedorFormMenuDueno.add(botonGestionarInventario_D, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 250, 360, 40));

        iconoGestionarInventarioMenuDueno_4.setBackground(new java.awt.Color(255, 255, 255));
        iconoGestionarInventarioMenuDueno_4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoGenerarPreListaMenuDueno_4.png"))); // NOI18N
        contenedorFormMenuDueno.add(iconoGestionarInventarioMenuDueno_4, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 300, -1, 40));

        botonGenerarPreLista_D.setBackground(new java.awt.Color(96, 121, 128));
        botonGenerarPreLista_D.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonGenerarPreLista_D.setText("GENERAR PRE LISTA DE PRODUCTOS");
        contenedorFormMenuDueno.add(botonGenerarPreLista_D, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 300, 360, 40));

        botonCerrarSesion_D.setBackground(new java.awt.Color(20, 41, 52));
        botonCerrarSesion_D.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonCerrarSesion_D.setForeground(new java.awt.Color(204, 204, 204));
        botonCerrarSesion_D.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBotonLogoutMenuDueno_5.png"))); // NOI18N
        botonCerrarSesion_D.setText("     CERRAR SESIÓN");
        contenedorFormMenuDueno.add(botonCerrarSesion_D, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 520, 240, 40));

        fondoDelFormMD.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/2.0_fondoPantallaMenu_D.jpeg"))); // NOI18N
        fondoDelFormMD.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        contenedorFormMenuDueno.add(fondoDelFormMD, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 580));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormMenuDueno, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormMenuDueno, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void botonGestionarInventario_DActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonGestionarInventario_DActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_botonGestionarInventario_DActionPerformed
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
                new f2_menuDueno().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton botonCerrarSesion_D;
    private javax.swing.JButton botonGenerarPreLista_D;
    private javax.swing.JButton botonGestionarInventario_D;
    private javax.swing.JButton botonGestionarUsuario;
    private javax.swing.JButton botonPuntoDeVenta_D;
    private javax.swing.JPanel contenedorFormMenuDueno;
    private javax.swing.JLabel fondoDelFormMD;
    private javax.swing.JLabel iconoGestionarInventarioMenuDueno_3;
    private javax.swing.JLabel iconoGestionarInventarioMenuDueno_4;
    private javax.swing.JLabel iconoGestionarUsuarioMenuDueno_2;
    private javax.swing.JLabel iconoPuntoDeVentaMenuDueno_1;
    // End of variables declaration//GEN-END:variables
}
