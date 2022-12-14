package pantallas;

import conexion.Conexion;
import java.io.FileWriter;
import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.time.Instant;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import pantallas.f1_login;
import pantallas.f2_menuDueno;
import pantallas.f2_menuEncargado;
import pantallas.f7_generarPreLista;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f4_generarReporte extends javax.swing.JFrame {

    public f4_generarReporte() {
        initComponents();
    }
    int rol = f1_login.rol;
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormGenerarReporte = new javax.swing.JPanel();
        etiquetaFechaInicioDeReporte = new javax.swing.JLabel();
        etiquetaFechaFinalDeReporte = new javax.swing.JLabel();
        f = new com.toedter.calendar.JDateChooser();
        f1 = new com.toedter.calendar.JDateChooser();
        btxt = new javax.swing.JButton();
        botonRegresarAPuntoDeVenta = new javax.swing.JButton();
        fondoGR = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("GENERAR REPORTE");

        contenedorFormGenerarReporte.setBackground(new java.awt.Color(102, 204, 255));
        contenedorFormGenerarReporte.setMinimumSize(new java.awt.Dimension(1000, 500));
        contenedorFormGenerarReporte.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormGenerarReporte.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        etiquetaFechaInicioDeReporte.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaFechaInicioDeReporte.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/R)iconoFechaInicial_GR_1.png"))); // NOI18N
        etiquetaFechaInicioDeReporte.setText("FECHA DE INICIO DE REPORTE:");
        contenedorFormGenerarReporte.add(etiquetaFechaInicioDeReporte, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 140, 210, 30));

        etiquetaFechaFinalDeReporte.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaFechaFinalDeReporte.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/S)iconoFechaFinal_GR_2.png"))); // NOI18N
        etiquetaFechaFinalDeReporte.setText("FECHA FINAL DE REPORTE:");
        contenedorFormGenerarReporte.add(etiquetaFechaFinalDeReporte, new org.netbeans.lib.awtextra.AbsoluteConstraints(539, 140, -1, 30));
        contenedorFormGenerarReporte.add(f, new org.netbeans.lib.awtextra.AbsoluteConstraints(530, 180, 200, 30));
        contenedorFormGenerarReporte.add(f1, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 180, 200, 30));

        btxt.setBackground(new java.awt.Color(69, 100, 123));
        btxt.setFont(new java.awt.Font("Cambria", 0, 36)); // NOI18N
        btxt.setForeground(new java.awt.Color(255, 255, 255));
        btxt.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/T)iconoGenerarTXT_GR_3.png"))); // NOI18N
        btxt.setText("GENERAR TXT");
        btxt.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btxtActionPerformed(evt);
            }
        });
        contenedorFormGenerarReporte.add(btxt, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 280, 410, 80));

        botonRegresarAPuntoDeVenta.setBackground(new java.awt.Color(40, 64, 72));
        botonRegresarAPuntoDeVenta.setFont(new java.awt.Font("Cambria", 0, 18)); // NOI18N
        botonRegresarAPuntoDeVenta.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAPuntoDeVenta.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/U)iconoBotonRegresarAPuntoDeVenta_GR_4.png"))); // NOI18N
        botonRegresarAPuntoDeVenta.setText("     REGRESAR A PUNTO DE VENTA");
        botonRegresarAPuntoDeVenta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonRegresarAPuntoDeVentaActionPerformed(evt);
            }
        });
        contenedorFormGenerarReporte.add(botonRegresarAPuntoDeVenta, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 450, 340, -1));

        fondoGR.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/5)fondoPantallaGenerarReporte.jpeg"))); // NOI18N
        fondoGR.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        fondoGR.setMaximumSize(new java.awt.Dimension(1000, 500));
        fondoGR.setMinimumSize(new java.awt.Dimension(1000, 500));
        fondoGR.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormGenerarReporte.add(fondoGR, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 500));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGenerarReporte, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGenerarReporte, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void botonRegresarAPuntoDeVentaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonRegresarAPuntoDeVentaActionPerformed
        if(rol == 1){
                    new f2_menuDueno().setVisible(true);
                   dispose();
                }else{
                    new f2_menuEncargado().setVisible(true);
                   dispose();
                }
    }//GEN-LAST:event_botonRegresarAPuntoDeVentaActionPerformed

    private void btxtActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btxtActionPerformed
        SimpleDateFormat Formato2 = new SimpleDateFormat("dd-MM-yy");                                          
        Date date = Date.from(Instant.now());
        String Fecha = Formato2.format(date);
        
        FileWriter fw = null;
        try {
            Conexion baseDatos = new Conexion().conectar();
            StringBuffer str_buf = new StringBuffer();
            String ruta = "C:\\Users\\Jorge Poseros\\Desktop\\prelista y reportes\\reporte de ventas de: "+ Fecha + ".txt";
            fw = new FileWriter(ruta);
            ResultSet rs = baseDatos.consultar("SELECT id_ventas, id_producto, cantidad, fecha, precio FROM ventas, productos WHERE FECHA BETWEEN '"+f+"' AND '"+f1+"'");
            
            String data_row = "";
            fw.write("id_ventas, id_producto, cantidad, fecha, precio");
            while (rs.next()) {
                data_row = "\n";
                data_row += rs.getLong("id_ventas");
                data_row += ",\"" + rs.getString("id_producto").trim()
                        + "\"";
                data_row += ",\"" +
                        rs.getString("cantidad").trim() + "\"";
                data_row += ",\"" +
                        rs.getString("fecha").trim() + "\"";
                
                fw.write(data_row);
            }          fw.close();
        } catch (IOException ex) {
            Logger.getLogger(f7_generarPreLista.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(f7_generarPreLista.class.getName()).log(Level.SEVERE, null, ex);
        } finally { 
            try {
                fw.close();
            } catch (IOException ex) {
                Logger.getLogger(f7_generarPreLista.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        JOptionPane.showMessageDialog(null,"Reporte generado",null, JOptionPane.INFORMATION_MESSAGE);
    }//GEN-LAST:event_btxtActionPerformed
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
            java.util.logging.Logger.getLogger(f4_generarReporte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f4_generarReporte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f4_generarReporte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f4_generarReporte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
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
                new f4_generarReporte().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton botonRegresarAPuntoDeVenta;
    private javax.swing.JButton btxt;
    private javax.swing.JPanel contenedorFormGenerarReporte;
    private javax.swing.JLabel etiquetaFechaFinalDeReporte;
    private javax.swing.JLabel etiquetaFechaInicioDeReporte;
    private com.toedter.calendar.JDateChooser f;
    private com.toedter.calendar.JDateChooser f1;
    private javax.swing.JLabel fondoGR;
    // End of variables declaration//GEN-END:variables
}
