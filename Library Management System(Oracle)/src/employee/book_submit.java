/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package employee;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import javax.swing.JOptionPane;

/**
 *
 * @author acer
 */
public class book_submit extends javax.swing.JFrame {

    /**
     * Creates new form book_submit
     */
    public book_submit() {
        initComponents();
        add();
        add1();
    }
    public void add()
    {
        try {
            Class.forName("oracle.jdbc.driver.OracleDriver");

            Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:rayhan", "rayhan", "123");
            String query =  "select std_id,std_name from student ORDER BY STD_ID ASC";
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(query);
            while(rs.next())
            {
                ab1.addItem(rs.getString(1)+" ( "+rs.getString(2)+" )");
            }
             } catch (Exception e) {
            System.out.println(e);
        }
    }
    public void add1()
    {
        try {
            Class.forName("oracle.jdbc.driver.OracleDriver");

            Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:rayhan", "rayhan", "123");
            String query =  "select book_id,book_name from book order by book_id asc";
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery(query);
            while(rs.next())
            {
                cb1.addItem(rs.getString(1)+" ( "+rs.getString(2)+" )");
            }
             } catch (Exception e) {
            System.out.println(e);
        }
    }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        ab1 = new javax.swing.JComboBox<>();
        cb1 = new javax.swing.JComboBox<>();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jButton1.setText("SUBMIT");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jButton2.setText("BACK");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jLabel1.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        jLabel1.setText("BOOK SUBMIT");

        jLabel2.setFont(new java.awt.Font("Arial Unicode MS", 0, 11)); // NOI18N
        jLabel2.setText("Book ID");

        jLabel3.setFont(new java.awt.Font("Arial Unicode MS", 0, 11)); // NOI18N
        jLabel3.setText("Student ID");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                            .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 58, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                            .addComponent(ab1, javax.swing.GroupLayout.PREFERRED_SIZE, 226, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGroup(layout.createSequentialGroup()
                            .addGap(12, 12, 12)
                            .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                            .addComponent(cb1, javax.swing.GroupLayout.PREFERRED_SIZE, 226, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                            .addGap(87, 87, 87)
                            .addComponent(jButton2)
                            .addGap(92, 92, 92)
                            .addComponent(jButton1))
                        .addGroup(layout.createSequentialGroup()
                            .addGap(108, 108, 108)
                            .addComponent(jLabel1))))
                .addContainerGap(54, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 32, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(62, 62, 62)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(ab1, javax.swing.GroupLayout.PREFERRED_SIZE, 32, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cb1, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 20, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(32, 32, 32)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButton2)
                    .addComponent(jButton1))
                .addContainerGap(51, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
    public static String now(String dateFormat) {
    Calendar cal = Calendar.getInstance();
    SimpleDateFormat sdf = new SimpleDateFormat(dateFormat);
    return sdf.format(cal.getTime());
    }
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        try {
            Class.forName("oracle.jdbc.driver.OracleDriver");

            Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:rayhan", "rayhan", "123");

            Statement stmt = con.createStatement();
            String ID1 = "";
            String ID2 = "";
            
            String book = cb1.getSelectedItem().toString();
            String student = ab1.getSelectedItem().toString();
            for(int i=0; i<book.length(); i++)
            {
                if(book.charAt(i)==' ' && book.charAt(i+1)=='(')break;
                ID2+=book.charAt(i);
            }
            for(int i=0; i<student.length(); i++)
            {
                if(student.charAt(i)==' ' && student.charAt(i+1)=='(')break;
                ID1+=student.charAt(i);
            }
            book=ID2;
            student=ID1;
            
            String sq="select BOOK_CNT from BOOK where BOOK_ID=?";
            PreparedStatement  st2 =con.prepareStatement(sq);
            st2.setString(1,book);
            ResultSet rs = st2.executeQuery();
            if(rs.next())
            {
                //System.out.println("YES");
                String cnt=rs.getString(1);
                int c=Integer.parseInt(cnt);
                if(c>0)
                {
                    c=c+1;
                    //for fine calculation
                    String cur_date=now("dd/MM/yyyy");
                    String q="select submission_date from lib_acc where std_id=? and book_id=? and status=?";
                    PreparedStatement st1 = con.prepareStatement(q);
                    st1.setString(1,student);
                    st1.setString(2,book);
                    st1.setString(3,"pending");
                    ResultSet rs1 = st1.executeQuery();
                    SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
                    String date="";
                    if(rs1.next())
                    {
                        date=rs1.getString(1);
                    }
                    Date dt1 = sdf.parse(cur_date);
                    Date dt2 = sdf.parse(date);
                    long diff = dt2.getTime() - dt1.getTime();
                    long day =  diff / 1000L / 60L / 60L / 24L;
                    if(Math.abs(day)>7)
                    {
                        System.out.println("yes"+" "+day);
                        String query1 = "update student set total_fine=? where std_id=?";
                        String query2 = "select total_fine from student where std_id=?";
                        PreparedStatement q11 = con.prepareStatement(query1);
                        PreparedStatement q22 = con.prepareStatement(query2);
                        q22.setString(1, student);
                        ResultSet qrs = q22.executeQuery();
                        String fine="";
                        if(qrs.next())
                        {
                            fine=qrs.getString(1);
                        }
                        int total_fine=Integer.parseInt(fine);
                        total_fine+=Math.abs(day)*5;
                        q11.setString(1,String.valueOf(total_fine));
                        q11.setString(2,student);
                        q11.execute();
                    }
                    System.out.println("yes");
                    // update submission date and status        
                    String q1= "update LIB_ACC set SUBMISSION_DATE=?,STATUS=?  where BOOK_ID=? and STD_ID=?";
                    PreparedStatement  st5 =con.prepareStatement(q1);
                    st5.setString(1, cur_date);
                    st5.setString(2, "recieved");
                    st5.setString(3,book);
                    st5.setString(4,student);
                    st5.execute();
                    // update book count
                    String qu="update book set BOOK_CNT=? where BOOK_ID=?";
                    PreparedStatement  st =con.prepareStatement(qu);
                    st.setString(1,String.valueOf(c));
                    st.setString(2,book);
                    st.execute();
                    JOptionPane.showMessageDialog(null, "Book Submitted Successfully");
                    con.close();
                   
                }
                else
                JOptionPane.showMessageDialog(null, "Book Not Available");
            }
        } catch (Exception e) {
            System.out.println(e);
        }
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        this.setVisible(false);
        store st =  new store();
        st.setVisible(true);
    }//GEN-LAST:event_jButton2ActionPerformed

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
            java.util.logging.Logger.getLogger(book_submit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(book_submit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(book_submit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(book_submit.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new book_submit().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox<String> ab1;
    private javax.swing.JComboBox<String> cb1;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    // End of variables declaration//GEN-END:variables
}