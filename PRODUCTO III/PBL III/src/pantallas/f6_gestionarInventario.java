package pantallas;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f6_gestionarInventario extends javax.swing.JFrame {

    public f6_gestionarInventario() {
        initComponents();
    }
    
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormGestionarInventario = new javax.swing.JPanel();
        etiquetaBusquedaPor = new javax.swing.JLabel();
        filtroDeBusqueda = new javax.swing.JComboBox<>();
        valorBusqueda = new javax.swing.JTextField();
        botonBusquedaArticuloGI = new javax.swing.JButton();
        campoID = new javax.swing.JTextField();
        campoNombreArticulo = new javax.swing.JTextField();
        campoPrecioArticulo = new javax.swing.JTextField();
        campoCantidadSeguridad = new javax.swing.JTextField();
        campoCantidadActual = new javax.swing.JTextField();
        barraDeslizanteGI = new javax.swing.JScrollBar();
        tablaInventarioDeArticulos = new javax.swing.JScrollPane();
        tablaDeInventario = new javax.swing.JTable();
        botonBorrarArticulo = new javax.swing.JButton();
        botonModificarArticulo = new javax.swing.JButton();
        botonDarDeAltaArticulo = new javax.swing.JButton();
        botonRegresarAMenu = new javax.swing.JButton();
        fondoDelFormGI = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("GESTIONAR INVENTARIO");

        contenedorFormGestionarInventario.setBackground(new java.awt.Color(255, 255, 255));
        contenedorFormGestionarInventario.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        etiquetaBusquedaPor.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaBusquedaPor.setText("BUSCAR POR:");
        contenedorFormGestionarInventario.add(etiquetaBusquedaPor, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 150, 70, 20));

        filtroDeBusqueda.setBackground(new java.awt.Color(147, 175, 197));
        filtroDeBusqueda.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        filtroDeBusqueda.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "ID_ARTICULO", "NOMBRE_ARTICULO", "PRECIO_ARTICULO", " " }));
        filtroDeBusqueda.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                filtroDeBusquedaActionPerformed(evt);
            }
        });
        contenedorFormGestionarInventario.add(filtroDeBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 150, 170, -1));
        contenedorFormGestionarInventario.add(valorBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 150, 390, -1));

        botonBusquedaArticuloGI.setBackground(new java.awt.Color(74, 96, 106));
        botonBusquedaArticuloGI.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBusquedaArticuloGI.setForeground(new java.awt.Color(255, 255, 255));
        botonBusquedaArticuloGI.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBusquedaDeArticulo_GI_1.png"))); // NOI18N
        botonBusquedaArticuloGI.setText("BUSCAR ARTÍCULO");
        contenedorFormGestionarInventario.add(botonBusquedaArticuloGI, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 130, 170, -1));

        campoID.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoID.setText("ID_Articulo");
        contenedorFormGestionarInventario.add(campoID, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 180, 80, -1));

        campoNombreArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoNombreArticulo.setText("Nombre_Articulo");
        contenedorFormGestionarInventario.add(campoNombreArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 180, 100, -1));

        campoPrecioArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoPrecioArticulo.setText("Precio_Articulo");
        contenedorFormGestionarInventario.add(campoPrecioArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(270, 180, 100, -1));

        campoCantidadSeguridad.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoCantidadSeguridad.setText("Cantidad_Seguridad");
        contenedorFormGestionarInventario.add(campoCantidadSeguridad, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 180, 110, -1));

        campoCantidadActual.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoCantidadActual.setText("Cantidad_Actual");
        contenedorFormGestionarInventario.add(campoCantidadActual, new org.netbeans.lib.awtextra.AbsoluteConstraints(500, 180, 100, -1));
        contenedorFormGestionarInventario.add(barraDeslizanteGI, new org.netbeans.lib.awtextra.AbsoluteConstraints(910, 240, 10, 180));

        tablaDeInventario.setAutoCreateRowSorter(true);
        tablaDeInventario.setBackground(new java.awt.Color(204, 204, 255));
        tablaDeInventario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        tablaDeInventario.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "ID_ARTICULO", "NOMBRE_ARTICULO", "PRECIO_ARTICULO", "CANTIDAD_SEGURIDAD", "CANTIDAD_ACTUAL_PRODUCTO"
            }
        ));
        tablaInventarioDeArticulos.setViewportView(tablaDeInventario);

        contenedorFormGestionarInventario.add(tablaInventarioDeArticulos, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 210, 860, 220));

        botonBorrarArticulo.setBackground(new java.awt.Color(74, 96, 106));
        botonBorrarArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBorrarArticulo.setForeground(new java.awt.Color(255, 255, 255));
        botonBorrarArticulo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBorrarArticuloGestionarInventario_4.png"))); // NOI18N
        botonBorrarArticulo.setText("BORRAR ARTÍCULO");
        contenedorFormGestionarInventario.add(botonBorrarArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(760, 440, 170, -1));

        botonModificarArticulo.setBackground(new java.awt.Color(74, 96, 106));
        botonModificarArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonModificarArticulo.setForeground(new java.awt.Color(255, 255, 255));
        botonModificarArticulo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoModificarArticuloGestionarInventario_3.png"))); // NOI18N
        botonModificarArticulo.setText("MODIFICAR ARTÍCULO");
        botonModificarArticulo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonModificarArticuloActionPerformed(evt);
            }
        });
        contenedorFormGestionarInventario.add(botonModificarArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(560, 440, 190, -1));

        botonDarDeAltaArticulo.setBackground(new java.awt.Color(74, 96, 106));
        botonDarDeAltaArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonDarDeAltaArticulo.setForeground(new java.awt.Color(255, 255, 255));
        botonDarDeAltaArticulo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoDarDeAltaArticuloGestionarInventario_2.png"))); // NOI18N
        botonDarDeAltaArticulo.setText("DAR DE ALTA ARTÍCULO");
        contenedorFormGestionarInventario.add(botonDarDeAltaArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 440, 200, -1));

        botonRegresarAMenu.setBackground(new java.awt.Color(74, 96, 106));
        botonRegresarAMenu.setFont(new java.awt.Font("Cambria", 0, 30)); // NOI18N
        botonRegresarAMenu.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAMenu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBotonRegresarAMenu_GI_5.png"))); // NOI18N
        botonRegresarAMenu.setText("REGRESAR A MENÚ");
        contenedorFormGestionarInventario.add(botonRegresarAMenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 490, 360, 70));

        fondoDelFormGI.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/6_fondoPantallaGestionarInventario.jpeg"))); // NOI18N
        fondoDelFormGI.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        contenedorFormGestionarInventario.add(fondoDelFormGI, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 580));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGestionarInventario, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGestionarInventario, javax.swing.GroupLayout.PREFERRED_SIZE, 580, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void filtroDeBusquedaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_filtroDeBusquedaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_filtroDeBusquedaActionPerformed

    private void botonModificarArticuloActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonModificarArticuloActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_botonModificarArticuloActionPerformed
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
            java.util.logging.Logger.getLogger(f6_gestionarInventario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f6_gestionarInventario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f6_gestionarInventario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f6_gestionarInventario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
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
                new f6_gestionarInventario().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JScrollBar barraDeslizanteGI;
    private javax.swing.JButton botonBorrarArticulo;
    private javax.swing.JButton botonBusquedaArticuloGI;
    private javax.swing.JButton botonDarDeAltaArticulo;
    private javax.swing.JButton botonModificarArticulo;
    private javax.swing.JButton botonRegresarAMenu;
    private javax.swing.JTextField campoCantidadActual;
    private javax.swing.JTextField campoCantidadSeguridad;
    private javax.swing.JTextField campoID;
    private javax.swing.JTextField campoNombreArticulo;
    private javax.swing.JTextField campoPrecioArticulo;
    private javax.swing.JPanel contenedorFormGestionarInventario;
    private javax.swing.JLabel etiquetaBusquedaPor;
    private javax.swing.JComboBox<String> filtroDeBusqueda;
    private javax.swing.JLabel fondoDelFormGI;
    private javax.swing.JTable tablaDeInventario;
    private javax.swing.JScrollPane tablaInventarioDeArticulos;
    private javax.swing.JTextField valorBusqueda;
    // End of variables declaration//GEN-END:variables
}
