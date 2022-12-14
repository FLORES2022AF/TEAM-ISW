package pantallas;

import conexion.Conexion;
import pantallas.f1_login;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.Vector;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import java.io.PrintWriter;
import java.io.FileOutputStream;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.io.*;
import java.time.Instant;
import java.util.logging.Level;
import java.util.logging.Logger;


/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f7_generarPreLista extends javax.swing.JFrame {

    Conexion baseDatos = new Conexion().conectar();

    Date d = new Date();
    
    public f7_generarPreLista() {
        initComponents();
        setLocationRelativeTo(null);
        cargartabla();
        botonGenerarPreListaPDF.setEnabled(true);
    }
    
   
    
    
    int rol = f1_login.rol;
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormGenerarPreLista = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        botonGenerarPreListaPDF = new javax.swing.JButton();
        botonRegresarAMenu = new javax.swing.JButton();
        fondoGPDP = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("GENERAR PRELISTA");
        setMinimumSize(new java.awt.Dimension(1000, 500));
        setPreferredSize(new java.awt.Dimension(1000, 500));

        contenedorFormGenerarPreLista.setBackground(new java.awt.Color(102, 204, 255));
        contenedorFormGenerarPreLista.setMinimumSize(new java.awt.Dimension(1000, 500));
        contenedorFormGenerarPreLista.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormGenerarPreLista.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        jScrollPane1.setViewportView(jTable1);

        contenedorFormGenerarPreLista.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 110, 630, 240));

        botonGenerarPreListaPDF.setBackground(new java.awt.Color(74, 96, 106));
        botonGenerarPreListaPDF.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonGenerarPreListaPDF.setForeground(new java.awt.Color(255, 255, 255));
        botonGenerarPreListaPDF.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/ZF)iconoGenerarTXT_GPL_1.png"))); // NOI18N
        botonGenerarPreListaPDF.setText("GENERAR PRE LISTA TXT");
        botonGenerarPreListaPDF.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonGenerarPreListaPDFActionPerformed(evt);
            }
        });
        botonGenerarPreListaPDF.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                botonGenerarPreListaPDFKeyReleased(evt);
            }
        });
        contenedorFormGenerarPreLista.add(botonGenerarPreListaPDF, new org.netbeans.lib.awtextra.AbsoluteConstraints(620, 360, 210, 50));

        botonRegresarAMenu.setBackground(new java.awt.Color(74, 96, 106));
        botonRegresarAMenu.setFont(new java.awt.Font("Cambria", 0, 18)); // NOI18N
        botonRegresarAMenu.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAMenu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/ZG)iconoBotonRegresarAMenu_GPL_2.png"))); // NOI18N
        botonRegresarAMenu.setText("REGRESAR A MENÚ");
        botonRegresarAMenu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonRegresarAMenuActionPerformed(evt);
            }
        });
        contenedorFormGenerarPreLista.add(botonRegresarAMenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 400, 230, 50));

        fondoGPDP.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/8)fondoPantallaGenerarPreLista.jpeg"))); // NOI18N
        fondoGPDP.setToolTipText("");
        fondoGPDP.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        fondoGPDP.setMaximumSize(new java.awt.Dimension(1000, 500));
        fondoGPDP.setMinimumSize(new java.awt.Dimension(1000, 500));
        fondoGPDP.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormGenerarPreLista.add(fondoGPDP, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, 500));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(contenedorFormGenerarPreLista, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGenerarPreLista, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents
    
    public void cargartabla(){
     DefaultTableModel modelo = new DefaultTableModel();
        this.jTable1.setModel(modelo);
        ResultSet rs = baseDatos.consultar("SELECT id_producto, descripcion, cantidad, cantidadR FROM productos where cantidad<= cantidadR"); 
            
        try {
            //Obteniendo la informacion de las columnas que estan siendo consultadas
            ResultSetMetaData rsMd = rs.getMetaData();
            //La cantidad de columnas que tiene la consulta
            int cantidadColumnas = rsMd.getColumnCount();
            //Establecer como cabezeras el nombre de las colimnas
            for (int i = 1; i <= cantidadColumnas; i++) {
             modelo.addColumn(rsMd.getColumnLabel(i));
            }
            //Creando las filas para el JTable
            while (rs.next()) {
             Object[] fila = new Object[cantidadColumnas];
             for (int i = 1; i <= cantidadColumnas; i++) {
               fila[i-1]=rs.getObject(i);               
               
             }
             modelo.addRow(fila);
            }
            rs.close();
            
       } catch (Exception ex) {
        ex.printStackTrace();
       }

    }
    
    
    private void botonRegresarAMenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonRegresarAMenuActionPerformed
          if(rol == 1){
                    new f2_menuDueno().setVisible(true);
                   dispose();
                }else{
                    new f2_menuEncargado().setVisible(true);
                   dispose();
                }
    }//GEN-LAST:event_botonRegresarAMenuActionPerformed

    private void botonGenerarPreListaPDFActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonGenerarPreListaPDFActionPerformed

        SimpleDateFormat Formato2 = new SimpleDateFormat("dd-MM-yy");                                          
        Date date = Date.from(Instant.now());
        String Fecha = Formato2.format(date);
        
        FileWriter fw = null;
        try {
            Conexion baseDatos = new Conexion().conectar();
            StringBuffer str_buf = new StringBuffer();
            String ruta = "C:\\Users\\jesus\\OneDrive\\Documentos\\prelista y reportes\\reportes de "+ Fecha + ".txt";
            fw = new FileWriter(ruta);
            ResultSet rs = baseDatos.consultar("SELECT id_producto, descripcion, cantidad, cantidadR FROM productos where cantidad<= cantidadR");
            String data_row = "";
            fw.write("id_producto, descripcion, cantidad, cantidadR");
            while (rs.next()) {
                data_row = "\n";
                data_row += rs.getLong("id_producto");
                data_row += ",\"" + rs.getString("descripcion").trim()
                        + "\"";
                data_row += ",\"" +
                        rs.getString("cantidad").trim() + "\"";
                data_row += ",\"" +
                        rs.getString("cantidadR").trim() + "\"";
                
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
                if(baseDatos.consultar("SELECT id_producto, descripcion, cantidad, cantidadR FROM productos where cantidad<= cantidadR") == null)
        {
            JOptionPane.showMessageDialog(null,"No existen productos en el inventario",null, JOptionPane.ERROR_MESSAGE);
        }
        JOptionPane.showMessageDialog(null,"TXT Generado",null, JOptionPane.INFORMATION_MESSAGE);
    }//GEN-LAST:event_botonGenerarPreListaPDFActionPerformed

    private void botonGenerarPreListaPDFKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_botonGenerarPreListaPDFKeyReleased
        
    }//GEN-LAST:event_botonGenerarPreListaPDFKeyReleased
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
            java.util.logging.Logger.getLogger(f7_generarPreLista.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f7_generarPreLista.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f7_generarPreLista.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f7_generarPreLista.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
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
                new f7_generarPreLista().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton botonGenerarPreListaPDF;
    private javax.swing.JButton botonRegresarAMenu;
    private javax.swing.JPanel contenedorFormGenerarPreLista;
    private javax.swing.JLabel fondoGPDP;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTable1;
    // End of variables declaration//GEN-END:variables
}
