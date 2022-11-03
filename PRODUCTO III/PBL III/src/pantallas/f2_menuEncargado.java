package pantallas;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f2_menuEncargado extends javax.swing.JFrame {

    public f2_menuEncargado() {
        initComponents();
    }


    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormMenuEncargado = new javax.swing.JPanel();
        iconoPuntoDeVentaMenuEncargado = new javax.swing.JLabel();
        botonPuntoDeVenta_E = new javax.swing.JButton();
        iconoGestionarInventario_E = new javax.swing.JLabel();
        botonGestionarInventario_E = new javax.swing.JButton();
        iconoGenerarPreLista_E = new javax.swing.JLabel();
        botonGenerarPreLista_E = new javax.swing.JButton();
        botonCerrarSesion_E = new javax.swing.JButton();
        fondoDelFormME = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("MENÚ ENCARGADO");

        contenedorFormMenuEncargado.setBackground(new java.awt.Color(255, 255, 255));
        contenedorFormMenuEncargado.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        iconoPuntoDeVentaMenuEncargado.setBackground(new java.awt.Color(255, 255, 255));
        iconoPuntoDeVentaMenuEncargado.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoPuntoDeVentaMenuEncargado_1.png"))); // NOI18N
        contenedorFormMenuEncargado.add(iconoPuntoDeVentaMenuEncargado, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 140, -1, 40));

        botonPuntoDeVenta_E.setBackground(new java.awt.Color(96, 121, 128));
        botonPuntoDeVenta_E.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonPuntoDeVenta_E.setText("PUNTO DE VENTA");
        contenedorFormMenuEncargado.add(botonPuntoDeVenta_E, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 140, 360, 40));

        iconoGestionarInventario_E.setBackground(new java.awt.Color(255, 255, 255));
        iconoGestionarInventario_E.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoGestionarInventarioMenuEncargado_2.png"))); // NOI18N
        contenedorFormMenuEncargado.add(iconoGestionarInventario_E, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 210, -1, 40));

        botonGestionarInventario_E.setBackground(new java.awt.Color(96, 121, 128));
        botonGestionarInventario_E.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonGestionarInventario_E.setText("GESTIONAR INVENTARIO");
        botonGestionarInventario_E.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonGestionarInventario_EActionPerformed(evt);
            }
        });
        contenedorFormMenuEncargado.add(botonGestionarInventario_E, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 210, 360, 40));

        iconoGenerarPreLista_E.setBackground(new java.awt.Color(255, 255, 255));
        iconoGenerarPreLista_E.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoGestionarInventarioMenuEncargado_2.png"))); // NOI18N
        contenedorFormMenuEncargado.add(iconoGenerarPreLista_E, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 290, -1, 40));

        botonGenerarPreLista_E.setBackground(new java.awt.Color(96, 121, 128));
        botonGenerarPreLista_E.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonGenerarPreLista_E.setText("GENERAR PRE LISTA DE PRODUCTOS");
        contenedorFormMenuEncargado.add(botonGenerarPreLista_E, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 290, 360, 40));

        botonCerrarSesion_E.setBackground(new java.awt.Color(20, 41, 52));
        botonCerrarSesion_E.setFont(new java.awt.Font("Cambria", 0, 20)); // NOI18N
        botonCerrarSesion_E.setForeground(new java.awt.Color(204, 204, 204));
        botonCerrarSesion_E.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBotonLogoutMenuEncargado_4.png"))); // NOI18N
        botonCerrarSesion_E.setText("     CERRAR SESIÓN");
        botonCerrarSesion_E.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonCerrarSesion_EActionPerformed(evt);
            }
        });
        contenedorFormMenuEncargado.add(botonCerrarSesion_E, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 520, 240, 40));

        fondoDelFormME.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/2.0_fondoPantallaMenu_D.jpeg"))); // NOI18N
        fondoDelFormME.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        contenedorFormMenuEncargado.add(fondoDelFormME, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 580));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormMenuEncargado, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormMenuEncargado, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void botonGestionarInventario_EActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonGestionarInventario_EActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_botonGestionarInventario_EActionPerformed

    private void botonCerrarSesion_EActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonCerrarSesion_EActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_botonCerrarSesion_EActionPerformed
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
                new f2_menuEncargado().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton botonCerrarSesion_E;
    private javax.swing.JButton botonGenerarPreLista_E;
    private javax.swing.JButton botonGestionarInventario_E;
    private javax.swing.JButton botonPuntoDeVenta_E;
    private javax.swing.JPanel contenedorFormMenuEncargado;
    private javax.swing.JLabel fondoDelFormME;
    private javax.swing.JLabel iconoGenerarPreLista_E;
    private javax.swing.JLabel iconoGestionarInventario_E;
    private javax.swing.JLabel iconoPuntoDeVentaMenuEncargado;
    // End of variables declaration//GEN-END:variables
}
